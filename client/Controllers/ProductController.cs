using client.Models;
using client.Network;
using client.Services;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using client.Forms.POS.POSUserControl;
using client.Helpers;
using client.Services.Auth;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Sockets;
using client.Models.Audit;
using Newtonsoft.Json.Linq;

namespace client.Controllers
{
    public class ProductController
    {
        AuditService _auditService = new AuditService();
        public async Task<bool> Get()
        {
            try
            {
                Logger.Write("GET PRODUCT", "Sending request to server");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    DefaultBufferSize = 104857600
                };

                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.GetProduct,
                    Data = new Dictionary<string, string>()
                });

                if (response?.Data != null &&
                    response.Data.ContainsKey("success") &&
                    response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    if (response.Data.ContainsKey("products"))
                    {
                        var products = JsonSerializer.Deserialize<List<Product>>(
                            response.Data["products"],
                            options
                        );

                        if (products != null && products.Count > 0)
                        {
                            CurrentProduct.SetProducts(products);
                            Logger.Write("GET PRODUCT", $"Successfully retrieved {products.Count} products");
                            return true;
                        }
                    }
                }
                else
                {
                    string errorMessage = response?.Data?.ContainsKey("message") == true
                        ? response.Data["message"]
                        : "Unknown error occurred";
                    Logger.Write("GET PRODUCT", $"Server returned error: {errorMessage}");
                }

                return false;
            }
            catch (Exception ex)
            {
                Logger.Write("GET PRODUCT", $"Error: {ex.Message}");
                MessageBox.Show($"Error retrieving products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<List<Product>> GetAllProducts()
        {
            try
            {
                Logger.Write("GET ALL PRODUCTS", "Sending request to server");

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                    DefaultBufferSize = 104857600
                };

                var response = await Client.Instance.SendRequestAsync(new Packet
                {
                    Type = PacketType.GetProduct,
                    Data = new Dictionary<string, string>()
                });

                if (response?.Data != null &&
                    response.Data.ContainsKey("success") &&
                    response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    if (response.Data.ContainsKey("products"))
                    {
                        var products = JsonSerializer.Deserialize<List<Product>>(
                            response.Data["products"],
                            options
                        );

                        if (products != null && products.Count > 0)
                        {
                            CurrentProduct.SetProducts(products);
                            Logger.Write("GET ALL PRODUCTS", $"Successfully retrieved {products.Count} products");

                            foreach (var product in products)
                            {
                                Logger.Write("GET ALL PRODUCTS", $"Product: {product.productName} (ID: {product.productId})");

                                if (product.Ingredients != null && product.Ingredients.Count > 0)
                                {
                                    foreach (var ingredient in product.Ingredients)
                                    {
                                        Logger.Write("GET ALL PRODUCTS",
                                            $"  - Ingredient: InventoryItemId={ingredient.InventoryItemId}, Quantity={ingredient.Quantity}, Measure={ingredient.MeasureSymbol}");
                                    }
                                }
                                else
                                {
                                    Logger.Write("GET ALL PRODUCTS", "  - No ingredients found.");
                                }
                            }

                            return products;
                        }
                    }
                }
                else
                {
                    string errorMessage = response?.Data?.ContainsKey("message") == true
                        ? response.Data["message"]
                        : "Unknown error occurred";
                    Logger.Write("GET ALL PRODUCTS", $"Server returned error: {errorMessage}");
                    MessageBox.Show($"Failed to retrieve products: {errorMessage}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logger.Write("GET ALL PRODUCTS", $"Error: {ex.Message}");
                MessageBox.Show($"Error retrieving products: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return new List<Product>();
        }

        public async Task<bool> Create(
            string name,
            string image,
            string price,
            int categoryId,
            int subcategoryId,
            int unitId,
            int isActive,
            Dictionary<int, (InventoryItem item, decimal quantity, string? measureSymbol)> selectedIngredients)
        {
            var ingredientsList = selectedIngredients.Select(entry => new
            {
                InventoryItemId = entry.Key,
                Quantity = entry.Value.quantity,
                MeasureSymbol = entry.Value.measureSymbol
            }).ToList();

            string ingredientsJson = JsonSerializer.Serialize(ingredientsList);

            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.CreateProduct,
                Data = new Dictionary<string, string>
                {
                    { "pName", name },
                    { "image", image },
                    { "unitPrice", price },
                    { "catId", categoryId.ToString()},
                    { "scId", subcategoryId.ToString() },
                    { "unitId", unitId.ToString() },
                    { "isActive", isActive.ToString() },
                    { "ingredients", ingredientsJson }
                }
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (response.Data != null && response.Data.ContainsKey("success"))
            {
                if (response.Data["success"].Equals("true", StringComparison.OrdinalIgnoreCase))
                {
                    await _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Action = AuditActionType.Create,
                        Description = "Product created successfully",
                        OldValue = "No product existed",
                        NewValue = $"Name: {name}, Price: {price}",
                        EntityType = AuditEntityType.Product,
                        EntityId = ""
                    });

                    return true;
                }
                else
                {
                    string errorMessage = "Product creation failed: ";

                    if (response.Data.ContainsKey("message"))
                    {
                        errorMessage += response.Data["message"];
                    }
                    else
                    {
                        errorMessage += "Unknown error occurred";
                    }

                    MessageBox.Show(errorMessage, "Product creation Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return false;
                }
            }
            else
            {
                MessageBox.Show("Invalid response format from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> Update(int productId, string name, string image, string price,
            int categoryId, int subcategoryId, int unitId, int isActive)
        {
            var originalProduct = CurrentProduct.GetProductById(productId);
            Logger.Write("PRODUCT_AUDIT_DEBUG", $"productImage: {originalProduct?.productImage} image: {image}");

            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.UpdateProduct,
                Data = new Dictionary<string, string>
                {
                    { "productId", productId.ToString() },
                    { "pName", name },
                    { "image", image },
                    { "unitPrice", price },
                    { "catId", categoryId.ToString() },
                    { "scId", subcategoryId.ToString() },
                    { "unitId", unitId.ToString() },
                    { "isActive", isActive.ToString() }
                }
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (response.Data != null && response.Data.TryGetValue("success", out string? success) &&
                success.Equals("true", StringComparison.OrdinalIgnoreCase))
            {
                var changes = new Dictionary<string, object>();
                var oldValues = new Dictionary<string, object>();

                if (originalProduct?.productName != name)
                {
                    oldValues.Add("Name", originalProduct!.productName!);
                    changes.Add("Name", name);
                }

                if (originalProduct?.productImage != image)
                {
                    oldValues.Add("Image", "Old image");
                    changes.Add("Image", "New image");
                }

                if (originalProduct?.productPrice.ToString() != price)
                {
                    oldValues.Add("Price", originalProduct!.productPrice);
                    changes.Add("Price", price);
                }

                if (originalProduct?.categoryId != categoryId)
                {
                    oldValues.Add("CategoryId", originalProduct!.categoryId);
                    changes.Add("CategoryId", categoryId);
                }

                if (originalProduct?.subcategoryId != subcategoryId)
                {
                    oldValues.Add("SubcategoryId", originalProduct!.subcategoryId);
                    changes.Add("SubcategoryId", subcategoryId);
                }

                if (originalProduct?.unitId != unitId)
                {
                    oldValues.Add("UnitId", originalProduct!.unitId);
                    changes.Add("UnitId", unitId);
                }

                if (originalProduct?.isActive != isActive)
                {
                    oldValues.Add("Status", originalProduct?.isActive == 1 ? "Active" : "Inactive");
                    changes.Add("Status", isActive == 1 ? "Active" : "Inactive");
                }

                if (changes.Any())
                {
                    await _auditService.Log(new AuditRecord
                    {
                        UserId = CurrentUser.Current!.UserId,
                        Action = AuditActionType.Update,
                        Description = "Product updated successfully",
                        OldValue = string.Join(" | ", oldValues.Select(x => $"{x.Key}: {x.Value}")),
                        NewValue = string.Join(" | ", changes.Select(x => $"{x.Key}: {x.Value}")),
                        EntityType = AuditEntityType.Product,
                        EntityId = productId.ToString()
                    });
                }

                return true;
            }

            string errorMessage = response.Data?.ContainsKey("message") == true
                ? response.Data["message"]
                : "Unknown error occurred while updating product";

            MessageBox.Show($"Product update failed: {errorMessage}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        public async Task<bool> Destroy(int productId)
        {
            var response = await Client.Instance.SendRequestAsync(new Packet
            {
                Type = PacketType.DeleteProduct,
                Data = new Dictionary<string, string>
                {
                    { "productId", productId.ToString() }
                }
            });

            if (response == null)
            {
                MessageBox.Show("No response received from server", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (response.Data != null && response.Data.TryGetValue("success", out string? success) &&
                success.Equals("true", StringComparison.OrdinalIgnoreCase))
            {
                await _auditService.Log(new AuditRecord
                {
                    UserId = CurrentUser.Current!.UserId,
                    Action = AuditActionType.Delete,
                    Description = "Product deleted successfully",
                    OldValue = "",
                    NewValue = "PRODUCT_DELETED",
                    EntityType = AuditEntityType.Product,
                    EntityId = productId.ToString()
                });

                return true;
            }

            string errorMessage = response.Data?.ContainsKey("message") == true
                ? response.Data["message"]
                : "Unknown error occurred while deleting product";

            MessageBox.Show($"Product delete failed: {errorMessage}", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }
    }
}

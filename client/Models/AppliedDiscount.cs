using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Models
{
    public class AppliedDiscount
    {
        // Private fields for tracking discounts
        private static decimal _discountAmount = 0;
        private static Dictionary<int, (decimal unitPrice, int quantity)> _discountedItems
            = new Dictionary<int, (decimal unitPrice, int quantity)>();

        private static string _discountName = string.Empty;
        private static DiscountTypeEnum _discountType = DiscountTypeEnum.None;
        private static decimal _discountValue = 0;
        private static decimal _subtotal = 0;
        private static string _customerName = string.Empty;
        private static string _idNumber = string.Empty;
        private static bool _isDiscountSet = false;
        private static bool _isCustomerSet = false;

        public static string DiscountName => _discountName;
        public static DiscountTypeEnum DiscountType => _discountType;
        public static decimal DiscountValue => _discountValue;
        public static decimal TotalDiscount => _discountAmount;
        public static string CustomerName => _customerName;
        public static string CustomerIdNumber => _idNumber;
        public static decimal SubTotal => _subtotal;
        public static IReadOnlyDictionary<int, (decimal unitPrice, int quantity)> DiscountedItems => _discountedItems;

        public static event Action<decimal>? OnDiscountChanged;
        public static event Action? OnDiscountAppliedSuccess; 

        public enum DiscountTypeEnum
        {
            None,
            Percentage,
            Fixed
        }

        public static void SetDiscountDetails(string name, DiscountTypeEnum type, decimal value, decimal subtotal)
        {
            if (value < 0)
            {
                MessageBox.Show("Discount value must be non-negative.", "Invalid Discount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _discountName = name;
            _discountType = type;
            _discountValue = value;
            _subtotal = subtotal;
            _isDiscountSet = true;

            CalculateTotalDiscount();
            CheckAndApplyDiscount();
        }

        public static void SetCustomerDiscountDetails(string customerName, string idNumber)
        {
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(idNumber))
            {
                MessageBox.Show("Customer name and ID number must not be empty.", "Invalid Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _customerName = customerName;
            _idNumber = idNumber;
            _isCustomerSet = true;

            CheckAndApplyDiscount();
        }

        private static void CheckAndApplyDiscount()
        {
            if (_isDiscountSet && _isCustomerSet)
            {
                OnDiscountAppliedSuccess?.Invoke();
            }
        }

        // Calculate total discount based on the current discount type
        private static void CalculateTotalDiscount()
        {
            _discountAmount = 0;

            if (_discountType == DiscountTypeEnum.Percentage)
            {
                _discountAmount = 0.20m;
                                    // vat-able * 0.2
            }
            else if (_discountType == DiscountTypeEnum.Fixed)
            {
                _discountAmount = _discountValue;
            }

            OnDiscountChanged?.Invoke(_discountAmount);
        }

        // Add a discount for a specific product
        public static void AddDiscount(int productId, decimal unitPrice, int quantity)
        {
            if (_discountedItems.TryGetValue(productId, out var existing))
            {
                _discountedItems[productId] = (unitPrice, existing.quantity + quantity);
            }
            else
            {
                _discountedItems[productId] = (unitPrice, quantity);
            }
        }

        // Remove discount for a specific product
        public static void RemoveDiscount(int productId)
        {
            _discountedItems.Remove(productId);
        }

        // Increment the discount quantity for a product
        public static void IncrementDiscount(int productId)
        {
            if (_discountedItems.TryGetValue(productId, out var existing))
            {
                _discountedItems[productId] = (existing.unitPrice, existing.quantity + 1);
            }
        }

        // Decrement the discount quantity for a product
        public static void DecrementDiscount(int productId)
        {
            if (_discountedItems.TryGetValue(productId, out var existing))
            {
                if (existing.quantity > 1)
                {
                    _discountedItems[productId] = (existing.unitPrice, existing.quantity - 1);
                }
                else
                {
                    _discountedItems.Remove(productId);
                }
            }
        }

        // Reset all
        public static void Clear()
        {
            _discountAmount = 0;
            _discountedItems.Clear();
            _discountName = string.Empty;
            _discountType = DiscountTypeEnum.None;
            _discountValue = 0;
            _customerName = string.Empty;
            _idNumber = string.Empty;
            OnDiscountChanged?.Invoke(0);
        }
    }
}

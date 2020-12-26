using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_Encapsulation_3.Models
{
    class Product
    {


        //public string ProdName { get; set; }
        //public decimal UnitPrice { get; set; }
        //public short UnitsInStock { get; set; }
        //public string RGBColor { get; set; }

        #region ProdName
        private string _productName;

        public string ProductName
        {
            get { return _productName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _productName = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
                }
                else
                {
                    _productName = "incorrect name";
                }
            }
        } 
        #endregion

        public decimal UnitPrice { get; set; }

        #region UnitsInStock
        private short _unitsInStock;
        public short UnitsInStock
        {
            get => _unitsInStock;
            set
            {
                _unitsInStock = value;
                switch (_unitsInStock)
                {
                    case short s when s <= 30:
                        {
                            _rgbColor = "#ffb142";
                            break;
                        }
                    case short s when s <= 50:
                        {
                            _rgbColor = "#ff793f";
                            break;
                        }
                    case short s when s <= 70:
                        {
                            _rgbColor = "#33d9b2";
                            break;
                        }
                    case short s when s <= 100:
                        {
                            _rgbColor = "#227093";
                            break;
                        }

                    default:
                        _rgbColor = "#b33939";
                        break;
                }
            }
        } 
        #endregion

        #region RGBColor
        private string _rgbColor;
        public string RGBColor { get => _rgbColor; }

        #endregion


    }
}

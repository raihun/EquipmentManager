using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // MessageBox
using System.Globalization; // StringInfo

namespace EquipmentManager {
    class Barcode {

        public int checkCode(string sBarcode) {
            int iBarcode;
            int iBarcodeLength = sBarcode.Length;

            // 文字長チェック
            if (iBarcodeLength != 8) {
                MessageBox.Show("バーコード文字列長 異常", "Error");
                return -1;
            }

            // 数値チェック
            if(int.TryParse(sBarcode, out iBarcode) == false) {
                MessageBox.Show("バーコード数値化 異常", "Error");
                return -1;
            }

            // チェックディジット
            int sum = 0;
            for (int i = 0; i < iBarcodeLength; i++) {
                if(i % 2 == 0) {
                    sum += int.Parse(sBarcode[i].ToString()) * 3;
                } else {
                    sum += int.Parse(sBarcode[i].ToString());
                }
            }

            if(sum % 10 == 0) {
                return iBarcode / 10;
            } else {
                MessageBox.Show("バーコード チェックディジット 異常", "Error");
                return -1;
            }
        }
    }
}

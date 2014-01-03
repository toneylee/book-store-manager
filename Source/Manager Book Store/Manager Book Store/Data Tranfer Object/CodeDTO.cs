using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;//thư viện hỗ trợ mã hóa MD5

namespace Manager_Book_Store.Data_Tranfer_Object
{
    class CodeDTO
    {
        //Hàm tạo mã MD5
        public string getMD5Hash(string input)
        {
            MD5 md5hash = MD5.Create();
            //chuyển chuỗi input thành mảng kiểu byte và tính toán để băm.
            byte[] data = md5hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            //Tạo một chuỗi string kiểu StringBuilder để chứa các byte và tạo chuyển thành chuỗi
            StringBuilder strBuilder = new StringBuilder();
            //Duyệt qua từng byte trong mảng băm và chuyển mỗi phần tử sang hệ thập lục
            for (int i = 0; i < data.Length; ++i)
                strBuilder.Append(data[i].ToString("x2"));
            // trả về một chuỗi hệ thập lục
            return strBuilder.ToString();
        }
        //Viết hàm kiểm tra lại quá trình dịch mã md5 có đung không?
        public bool VerifyMd5Hash(string input, string hash)
        {
            MD5 md5hash = MD5.Create();
            //Bảng băm từ input trong hàm
            string hashOfInput = getMD5Hash(input);
            //Tạo một chuỗi so sánh giữa hai mảng băm
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
                return true;
            else
                return false;
        }
    }
}

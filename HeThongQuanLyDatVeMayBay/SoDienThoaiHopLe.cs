using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyDatVeMayBay
{
    public class SoDienThoaiHopLe
    {
        public string CountryCode { get; set; } // Mã quốc gia, ví dụ: +84
        public string CountryName { get; set; } // Tên quốc gia, ví dụ: Vietnam
        public int MinLength { get; set; } // Độ dài tối thiểu của số điện thoại
        public int MaxLength { get; set; } // Độ dài tối đa của số điện thoại
        public bool RemoveLeadingZero { get; set; } // Có bỏ số 0 ở đầu không
        public List<string> ValidPrefixes { get; set; } // Danh sách đầu số hợp lệ (nếu có)

        public SoDienThoaiHopLe(string countryCode, string countryName, int minLength, int maxLength, bool removeLeadingZero, List<string> validPrefixes = null)
        {
            CountryCode = countryCode;
            CountryName = countryName;
            MinLength = minLength;
            MaxLength = maxLength;
            RemoveLeadingZero = removeLeadingZero;
            ValidPrefixes = validPrefixes ?? new List<string>();
        }

        public override string ToString()
        {
            return $"{CountryName} {CountryCode}";
        }
    }

    public static class CountryPhoneRules
    {
        public static List<SoDienThoaiHopLe> Rules = new List<SoDienThoaiHopLe>
        {
            new SoDienThoaiHopLe("+93", "Afghanistan", 9, 9, true, new List<string> { "70", "71", "72", "73", "74", "75", "76", "77", "78", "79" }),
            new SoDienThoaiHopLe("+355", "Albania", 9, 9, true, new List<string> { "66", "67", "68", "69" }),
            new SoDienThoaiHopLe("+213", "Algeria", 9, 9, true, new List<string> { "5", "6", "7" }),
            new SoDienThoaiHopLe("+376", "Andorra", 6, 9, false),
            new SoDienThoaiHopLe("+244", "Angola", 9, 9, false, new List<string> { "91", "92", "93", "94", "95", "96", "97", "98", "99" }),
            new SoDienThoaiHopLe("+54", "Argentina", 10, 10, true, new List<string> { "2", "3", "4", "5", "6", "7", "8", "9" }),
            new SoDienThoaiHopLe("+374", "Armenia", 8, 8, true, new List<string> { "55", "77", "91", "93", "94", "95", "96", "98", "99" }),
            new SoDienThoaiHopLe("+61", "Australia", 9, 9, true, new List<string> { "4" }),
            new SoDienThoaiHopLe("+43", "Austria", 10, 13, true, new List<string> { "6", "7" }),
            new SoDienThoaiHopLe("+994", "Azerbaijan", 9, 9, true, new List<string> { "50", "51", "55", "70", "77" }),
            new SoDienThoaiHopLe("+973", "Bahrain", 8, 8, false),
            new SoDienThoaiHopLe("+880", "Bangladesh", 10, 10, true, new List<string> { "13", "14", "15", "16", "17", "18", "19" }),
            new SoDienThoaiHopLe("+32", "Belgium", 9, 9, true, new List<string> { "4" }),
            new SoDienThoaiHopLe("+55", "Brazil", 10, 11, false, new List<string> { "11", "12", "13", "14", "15", "16", "17", "18", "19", "21", "22", "24", "27", "28" }),
            new SoDienThoaiHopLe("+359", "Bulgaria", 9, 9, true, new List<string> { "87", "88", "89", "98", "99" }),
            new SoDienThoaiHopLe("+1", "Canada", 10, 10, false),
            new SoDienThoaiHopLe("+56", "Chile", 9, 9, false, new List<string> { "9" }),
            new SoDienThoaiHopLe("+86", "China", 11, 11, false, new List<string> { "13", "14", "15", "17", "18" }),
            new SoDienThoaiHopLe("+57", "Colombia", 10, 10, false, new List<string> { "3" }),
            new SoDienThoaiHopLe("+385", "Croatia", 9, 9, true, new List<string> { "91", "92", "95", "98", "99" }),
            new SoDienThoaiHopLe("+53", "Cuba", 8, 8, false),
            new SoDienThoaiHopLe("+357", "Cyprus", 8, 8, false, new List<string> { "99" }),
            new SoDienThoaiHopLe("+420", "Czech Republic", 9, 9, false, new List<string> { "6", "7" }),
            new SoDienThoaiHopLe("+45", "Denmark", 8, 8, false),
            new SoDienThoaiHopLe("+20", "Egypt", 10, 10, true, new List<string> { "10", "11", "12", "15" }),
            new SoDienThoaiHopLe("+372", "Estonia", 8, 8, false, new List<string> { "5", "8" }),
            new SoDienThoaiHopLe("+358", "Finland", 9, 10, true, new List<string> { "4", "5" }),
            new SoDienThoaiHopLe("+33", "France", 9, 9, true, new List<string> { "6", "7" }),
            new SoDienThoaiHopLe("+995", "Georgia", 9, 9, true, new List<string> { "5", "7" }),
            new SoDienThoaiHopLe("+49", "Germany", 10, 11, true),
            new SoDienThoaiHopLe("+30", "Greece", 10, 10, false, new List<string> { "69" }),
            new SoDienThoaiHopLe("+852", "Hong Kong", 8, 8, false, new List<string> { "5", "6", "9" }),
            new SoDienThoaiHopLe("+36", "Hungary", 9, 9, true, new List<string> { "20", "30", "70" }),
            new SoDienThoaiHopLe("+354", "Iceland", 7, 7, false),
            new SoDienThoaiHopLe("+91", "India", 10, 10, false, new List<string> { "6", "7", "8", "9" }),
            new SoDienThoaiHopLe("+62", "Indonesia", 9, 12, true, new List<string> { "8" }),
            new SoDienThoaiHopLe("+98", "Iran", 10, 10, true, new List<string> { "9" }),
            new SoDienThoaiHopLe("+353", "Ireland", 9, 9, true, new List<string> { "8" }),
            new SoDienThoaiHopLe("+972", "Israel", 9, 9, true, new List<string> { "5", "7" }),
            new SoDienThoaiHopLe("+39", "Italy", 9, 10, true, new List<string> { "3" }),
            new SoDienThoaiHopLe("+81", "Japan", 9, 9, true, new List<string> { "70", "80", "90" }),
            new SoDienThoaiHopLe("+962", "Jordan", 9, 9, true, new List<string> { "7" }),
            new SoDienThoaiHopLe("+254", "Kenya", 9, 9, true, new List<string> { "7" }),
            new SoDienThoaiHopLe("+965", "Kuwait", 8, 8, false),
            new SoDienThoaiHopLe("+371", "Latvia", 8, 8, false, new List<string> { "2" }),
            new SoDienThoaiHopLe("+961", "Lebanon", 8, 8, false, new List<string> { "3", "7" }),
            new SoDienThoaiHopLe("+60", "Malaysia", 9, 10, true, new List<string> { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19" }),
            new SoDienThoaiHopLe("+52", "Mexico", 10, 10, false, new List<string> { "2", "3", "4", "5", "6", "7", "8", "9" }),
            new SoDienThoaiHopLe("+31", "Netherlands", 9, 9, true, new List<string> { "6" }),
            new SoDienThoaiHopLe("+64", "New Zealand", 9, 10, true, new List<string> { "2" }),
            new SoDienThoaiHopLe("+234", "Nigeria", 10, 10, true, new List<string> { "70", "80", "81", "90" }),
            new SoDienThoaiHopLe("+47", "Norway", 8, 8, false, new List<string> { "4", "9" }),
            new SoDienThoaiHopLe("+968", "Oman", 8, 8, false),
            new SoDienThoaiHopLe("+92", "Pakistan", 10, 10, true, new List<string> { "3" }),
            new SoDienThoaiHopLe("+63", "Philippines", 10, 10, true, new List<string> { "9" }),
            new SoDienThoaiHopLe("+48", "Poland", 9, 9, false, new List<string> { "5", "6", "7", "8" }),
            new SoDienThoaiHopLe("+351", "Portugal", 9, 9, false, new List<string> { "9" }),
            new SoDienThoaiHopLe("+974", "Qatar", 8, 8, false),
            new SoDienThoaiHopLe("+40", "Romania", 9, 9, true, new List<string> { "7" }),
            new SoDienThoaiHopLe("+7", "Russia", 10, 10, true, new List<string> { "9" }),
            new SoDienThoaiHopLe("+966", "Saudi Arabia", 9, 9, true, new List<string> { "5" }),
            new SoDienThoaiHopLe("+65", "Singapore", 8, 8, false, new List<string> { "8", "9" }),
            new SoDienThoaiHopLe("+421", "Slovakia", 9, 9, false, new List<string> { "9" }),
            new SoDienThoaiHopLe("+27", "South Africa", 9, 9, true, new List<string> { "6", "7", "8" }),
            new SoDienThoaiHopLe("+82", "South Korea", 9, 10, true, new List<string> { "10", "11", "16", "17", "18", "19" }),
            new SoDienThoaiHopLe("+34", "Spain", 9, 9, false, new List<string> { "6", "7" }),
            new SoDienThoaiHopLe("+94", "Sri Lanka", 9, 9, true, new List<string> { "7" }),
            new SoDienThoaiHopLe("+46", "Sweden", 9, 9, true, new List<string> { "7" }),
            new SoDienThoaiHopLe("+41", "Switzerland", 9, 9, true, new List<string> { "7" }),
            new SoDienThoaiHopLe("+66", "Thailand", 9, 9, true, new List<string> { "6", "8", "9" }),
            new SoDienThoaiHopLe("+90", "Turkey", 10, 10, true, new List<string> { "5" }),
            new SoDienThoaiHopLe("+971", "United Arab Emirates", 9, 9, true, new List<string> { "50", "55", "56", "58", "59" }),
            new SoDienThoaiHopLe("+44", "United Kingdom", 10, 10, true, new List<string> { "7" }),
            new SoDienThoaiHopLe("+1", "United States", 10, 10, false),
            new SoDienThoaiHopLe("+84", "Vietnam", 9, 9, true, new List<string> { "3", "5", "7", "8", "9" }),
        }.OrderBy(r => r.CountryName).ToList(); // Sắp xếp theo thứ tự ABC

        public static SoDienThoaiHopLe layQuyTacSoDienThoaiTheoQuocGia(string countryCode, string countryName = null)
        {
            if (string.IsNullOrEmpty(countryName))
            {
                return Rules.FirstOrDefault(r => r.CountryCode == countryCode);
            }
            return Rules.FirstOrDefault(r => r.CountryCode == countryCode && r.CountryName == countryName);
        }
    }
}
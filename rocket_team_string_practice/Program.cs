using System.Text;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;


namespace rocket_team_string_practice;

class Program
{
    public static string StringCheck(string s, string sentence)
    {
        while (String.IsNullOrEmpty(s))
        {
            Console.WriteLine(sentence);
            s = Console.ReadLine();
        }
        return s;
    }

    public static DateTime DateTimeCheck(string s, string sentence)
    {
        DateTime result;
        while (DateTime.TryParse(s, out result) == false)
        {
            Console.WriteLine(sentence);
            s = Console.ReadLine();
        }
        return result;
    }

    static void Main(string[] args)
    {
        //1.輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin。
        //string userName = "";
        //userName = StringCheck(userName, "請輸入姓名");
        //Console.WriteLine(userName.Insert(0, "Hi~"));


        //2.請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡。
        //string userEnter = "";
        //userEnter = StringCheck(userEnter, "請輸入任何一個字");
        //string sentence = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
        //if (sentence.Contains(userEnter))
        //{
        //    Console.WriteLine($"您輸入的字「{userEnter}」有出現在「{sentence}」裡");
        //}
        //else
        //{
        //    Console.WriteLine($"您輸入的字「{userEnter}」未出現在「{sentence}」裡");
        //}


        //3.輸入一段字，輸出每個之間多一個-，如輸入apple ，輸出a-p-p-l-e。
        //string userEnter = "";
        //userEnter = StringCheck(userEnter, "請輸入一段字");
        //int userEnterLength = userEnter.Length;
        //for (int i = 1; i < (userEnterLength * 2 - 2); i += 2)
        //{
        //    userEnter = userEnter.Insert(i, "-");
        //}
        //Console.WriteLine(userEnter);


        //4.輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg。
        //string fileName = "";
        //fileName = StringCheck(fileName, "請輸入一個檔名");
        //if (fileName.Contains('.'))
        //{
        //    int spaceIndex = fileName.IndexOf('.');
        //    Console.WriteLine($"檔案的副檔名為{fileName.Substring(spaceIndex + 1)}");
        //}
        //else
        //{
        //    Console.WriteLine("輸入內容不包含副檔名");
        //}


        //5.輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字。
        //string userEnter = "";
        //userEnter = StringCheck(userEnter, "請輸入一個大於五個字的單字");
        //if (userEnter.Length > 5)
        //{
        //    Console.WriteLine($"單字前三個字為{userEnter.Substring(0,3)}");
        //}
        //else
        //{
        //    Console.WriteLine("單字長度不夠") ;
        //}


        //6.輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌。
        //string userEnter = "";
        //userEnter = StringCheck(userEnter, "請輸入一段字");
        //if (userEnter.Contains("我"))
        //{
        //    Console.WriteLine(userEnter.Replace("我","小明"));
        //}
        //else
        //{
        //    Console.WriteLine("輸入的字中不包含「我」");
        //}


        //7.輸入一串字，顯示輸入幾個字。
        //string userEnter = "";
        //userEnter = StringCheck(userEnter, "請輸入一串字");
        //Console.WriteLine($"輸入共{userEnter.Length}字");


        //1.連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過。
        //string[] stringArray = new string[10];
        //for (int i = 0; i < 10; i++)
        //{
        //    string s = "";
        //    s = StringCheck(s, $"請輸入第{i + 1}組字");
        //    stringArray[i] = s;
        //    int indexOfS = Array.IndexOf(stringArray, s);
        //    if (indexOfS != i)
        //    {
        //        Console.WriteLine("輸入過了");
        //    }
        //    else
        //    {
        //        Console.WriteLine("沒出現過");
        //    }
        //}


        //2.用字母大小寫來模擬波浪舞的動作後輸出
        //string userEnter = "";
        //userEnter = StringCheck(userEnter, "請輸入一個字串").ToLower();
        //for (int i = 0; i < userEnter.Length; i++)
        //{
        //    char[] userEnterArr = userEnter.ToCharArray();
        //    userEnterArr[i] = Char.ToUpper(userEnterArr[i]);
        //    Console.WriteLine(userEnterArr);
        //}



        //3.輸入時間，顯示幾時幾分，例如輸入11:30，輸出11點30分。
        //string userEnter = "";
        //userEnter = StringCheck(userEnter, "請輸入時間");
        //if (userEnter.Contains(':'))
        //{
        //    int colonIndex = userEnter.IndexOf(':');
        //    Console.WriteLine($"現在是{userEnter.Substring(0, colonIndex)}點{userEnter.Substring(colonIndex + 1)}分");
        //}
        //else
        //{
        //    Console.WriteLine("輸入的非時間格式");
        //}


        //4.輸入的字，轉成HTML
        //List<string> userEnterList = new List<string> { "<html>", "<ul>", "</ul>", "</html>" };
        //string userEnter = "";
        //userEnter = StringCheck(userEnter, "請輸入一段包含\",\"的字");
        //if (userEnter.Contains(','))
        //{
        //    string[] enterArr = userEnter.Split(',');
        //    for(int i = 0; i < enterArr.Length; i++)
        //    {
        //        enterArr[i] = $"<li>{enterArr[i]}</li>";
        //    }
        //    userEnterList.InsertRange(2,enterArr);
        //}
        //foreach (string s in userEnterList)
        //{
        //    Console.WriteLine(s);
        //}
        //File.WriteAllLines("/Users/wangyahsien/Desktop/123.html", userEnterList);


        //5.輸入5處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87
        //string userEnter = "";
        //userEnter = StringCheck(userEnter, "請輸入數個用空白隔開的數字");
        //string[] userEnterArr = userEnter.Split(' ');
        //int output = 0;
        //for (int i = 0; i < userEnterArr.Length; i++)
        //{
        //    output += Convert.ToInt32(userEnterArr[i]);
        //}
        //Console.WriteLine($"總和為{output}");


        //6.輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ
        //string userEnter = "";
        //userEnter = StringCheck(userEnter, "請輸入一串文字");
        //string stringReverse = new string(userEnter.Reverse().ToArray());
        //Console.WriteLine(stringReverse);


        //7.寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)。
        //File.WriteAllText("/Users/wangyahsien/Desktop/123.txt","一閃一閃亮晶晶，滿天都是小星星",Encoding.UTF8);


        //8.讀取1.txt 顯示在畫面上。
        //Process.Start("/Users/wangyahsien/Desktop/123.txt");


        //9.寫入九九乘法表資料到一個文字檔到自己指定的文字檔。
        //List<string> nineMultiplyNine = new List<string>();
        //for (int i = 1; i <= 9; i++)
        //{
        //    for (int j = 1; j <= 9; j++)
        //    {
        //        nineMutiplyNine.Add($"{i} * {j} = {i * j}");
        //    }
        //}
        //File.WriteAllLines("/Users/wangyahsien/Desktop/123.txt", nineMutiplyNine);


        //10.讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF-8)
        //Process.Start("/Users/wangyahsien/Desktop/123.txt");
        //string fileString=File.ReadAllText("/Users/wangyahsien/Desktop/123.txt");
        //fileString=fileString.Replace("1", "壹").Replace("2","貳").Replace("3","參").Replace("4","肆").Replace("5","伍").Replace("6","陸").Replace("7","柒").Replace("8","捌").Replace("9","玖").Replace("0","零");
        //File.WriteAllText("/Users/wangyahsien/Desktop/123.txt",fileString,Encoding.UTF8);


        //11.讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。
        //List<string> fileRead = new List<string>(File.ReadLines("/Users/wangyahsien/Desktop/fc4bb.csv"));
        //for(int i = 0; i < fileRead.Count; i++)
        //{
        //    fileRead[i] = fileRead[i].Replace(",", "</td><td>");
        //    fileRead[i] = $"<tr><td>{fileRead[i]}</td></tr>";
        //    if (i == 0)
        //    {
        //        fileRead[i]= $"<th>{fileRead[i]}</th>";
        //    }
        //}
        //fileRead.Insert(0, "<html><table>");
        //fileRead.Add("</table></html>");
        //foreach(string s in fileRead)
        //{
        //    Console.WriteLine(s);
        //}
        //File.WriteAllLines("/Users/wangyahsien/Desktop/123.html",fileRead);


        //12.請隨機由0~99產生一個數字輸出。
        //Random r = new Random();
        //int r1 = r.Next(0, 100);
        //Console.WriteLine(r1);


        //13.請隨機由0~99產生10個數字輸出。
        //Random r = new Random();
        //for(int i = 0; i < 10; i++)
        //{
        //    int r1 = r.Next(0, 100);
        //    Console.WriteLine(r1);
        //}


        //14.隨機幫每位學員產生成績，並寫入文字檔(欄位之間用，分開，換行寫入下一筆)。
        //string[] students = new string[] { "Alex", "Ben", "Cathy", "Doris" };
        //Random r = new Random();
        //for (int i = 0; i < students.Length; i++)
        //{
        //    int r1 = r.Next(0, 101);
        //    File.AppendAllText("/Users/wangyahsien/Desktop/123.txt", $"{students[i]},{r1}分\n");
        //}


        //15.請設計樂透開獎程式。
        //List<int> numArray = new List<int>();
        //int special = 0;
        //Random r = new Random();
        //while (numArray.Count < 6)
        //{
        //    int r1 = r.Next(1, 50);
        //    if (numArray.IndexOf(r1) == -1)
        //    {
        //        numArray.Add(r1);
        //    }
        //}
        //while (special == 0)
        //{
        //    int r1 = r.Next(1, 50);
        //    if (numArray.IndexOf(r1) == -1)
        //    {
        //        special = r1;
        //    }
        //}
        //Console.WriteLine("本期開獎號碼為");
        //foreach (int i in numArray)
        //{
        //    Console.WriteLine(i);
        //}
        //Console.WriteLine($"特別號為{special}");


        //16.請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家。
        //string[] restaurant = File.ReadAllLines("/Users/wangyahsien/Desktop/restaurant.txt");
        //Random r = new Random();
        //int r1 = r.Next(1, restaurant.Length);
        //Console.WriteLine($"今天要吃{restaurant[r1]}");


        //17.請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，
        //隨機抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
        //List<string> students = new List<string>(File.ReadLines("/Users/wangyahsien/Desktop/students.txt"));
        //Random r = new Random();
        //for (int i = students.Count; i > 0; i--)
        //{
        //    int r1 = r.Next(0, students.Count);
        //    Console.WriteLine($"今天的值日生是{students[r1]}");
        //    students.Remove(students[r1]);
        //}


        //18.顯示現在日期與時間。
        //DateTime now = DateTime.Now;
        //Console.WriteLine($"現在是{now:西元yyyy年MM月dd日hh點mm分}");


        //19.顯示再過30天為哪一天。
        //DateTime now = DateTime.Now;
        //DateTime after30Days=now.AddDays(30);
        //Console.WriteLine($"30天後為{after30Days:西元yyyy年MM月dd日}");


        //20.顯示24小時前的年月日時分秒。
        //DateTime now = DateTime.Now;
        //DateTime before24Hours = now.AddHours(-24);
        //Console.WriteLine($"24小時前為{before24Hours:西元yyyy年MM月dd日hh時mm分ss秒}");


        //21.取得目前是幾月
        //DateTime now = DateTime.Now;
        //Console.WriteLine($"目前是{now.Month}月");


        //22.取得明年是否為閏年。(可以試試民國)
        //DateTime now = DateTime.Now;
        //DateTime nextYear = now.AddYears(1);
        //if (DateTime.IsLeapYear(nextYear.Year))
        //{
        //    Console.WriteLine($"明年是民國{nextYear.Year - 1911}年，是閏年");
        //}
        //else
        //{
        //    Console.WriteLine($"明年是民國{nextYear.Year - 1911}年，不是閏年");
        //}


        //23.取得離2025年1月1日還有幾天。
        //DateTime now = DateTime.Now;
        //DateTime anotherDate = new DateTime(2025, 1, 1);
        //int days = (anotherDate - now).Days;
        //Console.WriteLine(days);


        //24.星期一，猴子穿新衣，
        //星期二，猴子肚子餓，
        //星期三，猴子去爬山，
        //星期四，猴子看電視，
        //星期五，猴子去跳舞，
        //星期六，猴子去斗六，
        //星期日，猴子過生日。
        //請顯示今天猴子做甚麼事。
        //string[] monkeyDo = {
        //    "星期一，猴子穿新衣",
        //    "星期二，猴子肚子餓",
        //    "星期三，猴子去爬山",
        //    "星期四，猴子看電視",
        //    "星期五，猴子去跳舞",
        //    "星期六，猴子去斗六",
        //    "星期日，猴子過生日" };
        //DateTime today = DateTime.Today;
        //DayOfWeek dayOfToday = today.DayOfWeek;
        //switch (dayOfToday)
        //{
        //    case DayOfWeek.Monday:
        //        Console.WriteLine($"今天{monkeyDo[0]}");
        //        break;
        //    case DayOfWeek.Tuesday:
        //        Console.WriteLine($"今天{monkeyDo[1]}");
        //        break;
        //    case DayOfWeek.Wednesday:
        //        Console.WriteLine($"今天{monkeyDo[2]}");
        //        break;
        //    case DayOfWeek.Thursday:
        //        Console.WriteLine($"今天{monkeyDo[3]}");
        //        break;
        //    case DayOfWeek.Friday:
        //        Console.WriteLine($"今天{monkeyDo[4]}");
        //        break;
        //    case DayOfWeek.Saturday:
        //        Console.WriteLine($"今天{monkeyDo[5]}");
        //        break;
        //    case DayOfWeek.Sunday:
        //        Console.WriteLine($"今天{monkeyDo[6]}");
        //        break;
        //}


        //25.輸入‘兩個日期，輸出兩個日期相差幾天。
        //DateTime date1, date2;
        //string userEnter1 = "";
        //string userEnter2 = "";
        //date1 = DateTimeCheck(userEnter1, "請輸入第一個日期");
        //date2 = DateTimeCheck(userEnter2, "請輸入第二個日期");
        //Console.WriteLine($"兩個日期相差{Math.Abs((date2-date1).Days)}天");


        //26.兩光法師時常替人占卜，由於他算得又快有便宜，因此生意源源不絕，時常大排長龍，
        //他想算得更快一點，因此找了你這位電腦高手幫他用電腦來加快算命的速度。
        //他的占卜規則很簡單，規則是這樣的，隨機產生一個今年日期，然後依照下面的公式：
        //M = 月, D = 日, S = (M * 2 + D) % 3
        //得到S的值，再依照S的值從0到2分別給與"普通、吉、大吉"等三種不同的運勢，輸出運勢。
        //Random r = new Random();
        //int randomMonth = r.Next(1, 13);
        //int randomDate = r.Next(1, 32);
        //DateTime randomDay;
        //string stringOfDay = $"2024.{randomMonth}.{randomDate}";
        //randomDay = DateTimeCheck(stringOfDay, "產生隨機日期");
        //int m = randomDay.Month;
        //int d = randomDay.Day;
        //int result = (m * 2 + d) % 3;
        //switch (result)
        //{
        //    case 0:
        //        Console.WriteLine("運勢：普通");
        //        break;
        //    case 1:
        //        Console.WriteLine("運勢：吉");
        //        break;
        //    case 2:
        //        Console.WriteLine("運勢：大吉");
        //        break;
        //}


        Console.ReadKey();
    }

    //Fuction習題

    //1.寫一個function 可以把一般對話框的文字轉成HTML。
    // > 轉成 &gt;
    // < 轉成 &lt;
    // \r\n 轉成 <br>
    // | 轉成 &brvbar;
    // 空白 轉成 &nbsp;
    //public static string TransToHTML(string s)
    //{
    //    s = s.Replace(">", "&gt;").Replace("<", "&lt;");
    //    s = s.Replace(@"\r", "<br>").Replace(@"\n", "<br>");
    //    s = s.Replace("|", "&brvbar;").Replace(" ", "&nbsp;");
    //    return s;
    //}


    //2.寫一個function，回傳輸入的值是否數字
    //public static string IsNumber(string s)
    //{
    //    int intResult;
    //    double doubleResult;
    //    decimal decimalResult;
    //    if(Int32.TryParse(s,out intResult)||Double.TryParse(s,out doubleResult)||Decimal.TryParse(s,out decimalResult))
    //    {
    //        return "輸入的值是數字喔！";
    //    }
    //    else
    //    {
    //        return "輸入的值不是數字！";
    //    }
    //}


    //3.寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式
    //public static string IsEmail(string s)
    //{
    //    string pattern = @"^[A-Za-z0-9_.+-]+@[A-Za-z0-9-]+\.[A-Za-z-.]+$";
    //    Regex reObj = new Regex(pattern);
    //    if (reObj.IsMatch(s))
    //    {
    //        return "符合E-mail格式";
    //    }
    //    else
    //    {
    //        return "不符合E-mail格式";
    //    }
    //}


    //4.寫一個function，回傳輸入的值是否符合手機格式
    //public static string IsPhoneNumber(string s)
    //{
    //    string pattern = @"^[0][9]\d{8}$";
    //    Regex ReObj = new Regex(pattern);
    //    if (ReObj.IsMatch(s) == true)
    //    {
    //        return "符合手機格式";
    //    }
    //    else
    //    {
    //        return "不符合手機格式";
    //    }
    //}


    //5.寫一個function，回傳輸入的值是否符合身分證字號格式
    //public static string IsId(string s)
    //{
    //    string pattern = @"^[A-Z][12]\d{8}$";
    //    Regex reObj = new Regex(pattern);
    //    if (reObj.IsMatch(s) == true)
    //    {
    //        return "符合身分證字號格式";
    //    }
    //    else
    //    {
    //        return "不符合身分證字號格式";
    //    }
    //}


    //6.寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點
    //public static string ToDot(string s, int n)
    //{
    //    if (s.Length > n)
    //    {
    //        s = s.Substring(0, n);
    //        s = s + "...";
    //    }
    //    return s;
    //}


    //7.寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式
    //public static string ToROC(string s)
    //{
    //    DateTime date = DateTimeCheck(s, "請輸入一個日期");
    //    return $"日期為{date.Year-1911}.{date.Month}.{date.Day}";
    //}


    //8.寫一個function，輸入一個日期，把把該日期轉成民國XX年XX月XX日 星期X 格式
    //public static string ToROCDate(string s)
    //{
    //    DateTime date = DateTimeCheck(s, "請輸入一個日期");
    //    string dayOfWeek="";
    //    switch (date.DayOfWeek)
    //    {
    //        case DayOfWeek.Monday:
    //            dayOfWeek = "一";
    //            break;
    //        case DayOfWeek.Tuesday:
    //            dayOfWeek = "二";
    //            break;
    //        case DayOfWeek.Wednesday:
    //            dayOfWeek = "三";
    //            break;
    //        case DayOfWeek.Thursday:
    //            dayOfWeek = "四";
    //            break;
    //        case DayOfWeek.Friday:
    //            dayOfWeek = "五";
    //            break;
    //        case DayOfWeek.Saturday:
    //            dayOfWeek = "六";
    //            break;
    //        case DayOfWeek.Sunday:
    //            dayOfWeek = "天";
    //            break;
    //    }
    //    return $"日期為民國{date.Year - 1911}年{date.Month}月{date.Day}日 星期{dayOfWeek}";
    //}


    //9.寫一個function，回傳輸入的年是否閏年
    //public static string isLeapYear(string y)
    //{
    //    string pattern = @"^\d{1,4}$";
    //    Regex reObj = new Regex(pattern);
    //    while (reObj.IsMatch(y) == false)
    //    {
    //        Console.WriteLine("請輸入西元年份");
    //        y = Console.ReadLine();
    //    }
    //    if (int.Parse(y) % 4 == 0)
    //    {
    //        return $"{y}年為閏年";
    //    }
    //    else
    //    {
    //        return $"{y}年不是閏年";
    //    }
    //}


    //10.寫一個function，輸入手機號碼，回傳今天運勢
    //(手機運勢算法：用你的手機號碼的最後四位數除以80，
    //再減去整數部分（只留小數），
    //再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。)
    //public static string YourFortune(string s)
    //{
    //    string pattern = @"^[0][9]\d{8}$";
    //    Regex reObj = new Regex(pattern);
    //    while (reObj.IsMatch(s) == false)
    //    {
    //        Console.WriteLine("請輸入手機號碼");
    //        s = Console.ReadLine();
    //    }
    //    decimal luckyNum = Convert.ToInt32(s.Substring(6, 4));
    //    Console.WriteLine(luckyNum);
    //    decimal luckyNumPoint = luckyNum / 80.0m;
    //    Console.WriteLine(luckyNumPoint);
    //    luckyNumPoint = (luckyNumPoint - (int)luckyNumPoint) * 80;
    //    return $"你的幸運數字是{luckyNumPoint}";
    //}

}


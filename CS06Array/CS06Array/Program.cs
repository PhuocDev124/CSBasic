/*
    Member	                    Nội dung
    Length	            Thuộc tính cho biết số lượng phần tử trong mảng
    Rank	            Thuộc tính cho biết số chiều mảng
    Clone()	            Copy (nhân bản) đối tượng mảng
    GetValue(index)	    Lấy giá trị phần tử trong mảng
    Min()	            Trả về giá trị nhỏ nhất trong mảng
    Max()	            Trả về giá trị lớn nhất trong mảng
    Sum()	            Trả về giá trị tổng cộng các phần tử    
==> để sử dụng Min() Max() Sum() --> using System.Linq


            Member                                          Nội dung
    Array.BinarySearch(array, value)	            Tìm kiếm phần tử trong mảng đã được sắp xếp, trả về chỉ số nếu tìm thấy
    Array.CopyTo(array, indexStart)	                Sao chép phần tử mảng này sang mảng khác
    Array.Clear(array, index, length)	            Thiết lập phần tử mảng nhận giá trị mặc định
    Array.Exists<T> (array, Predicate<T> match);    Kiểm tra có phần tử trong mảng thỏa mãn match
    Array.Fill<T> (array, value);                   Gán các phần tử của mảng bằng value
    Array.Find<T> (array, Predicate<T> match);      Tìm phần tử mảng
    Array.FindIndex<T> (array, Predicate<T> match); Tìm phần tử mảng, trả về chỉ số nếu thấy
    Array.FindAll<T>(array, Predicate < T > match); Tìm tất cả phần tử mảng
    Array.IndexOf(array, value)	                    Tìm chỉ số của phần tử
    Array.ForEach(array, Action<T> action)	        Thi hành action trên mỗi phần tử
    Array.Sort(array)	                            Sắp xếp

* Predicate là một delegate trả về bool
* Action là một delegate có một tham số và không trả trị
* 
* Mảng nhìu chiều (Rank) (row x column)
* Mảng trong mảng (Mảng Jagged): là mảng mà các phần tử là các mảng 
*/

int[] numbers = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
int[] backupNumbers = new int[numbers.Length];
int[] evenNumbers = Array.FindAll(numbers, n =>
{
    return n % 2 == 0;
});

Array.ForEach(evenNumbers, n => Console.WriteLine(n));
Array.Copy(numbers, 3, backupNumbers, 0, numbers.Length - 3);
Console.WriteLine("-----------------");
Array.ForEach(backupNumbers, (n) => Console.WriteLine(n));
Console.WriteLine("---------------");
var x = Array.Find(numbers, (n) => n < 5);
Console.WriteLine(x);


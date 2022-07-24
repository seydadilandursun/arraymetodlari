//Sort
int[] sayiDizisi={23,12,4,86,72,3,11,17};

Console.WriteLine("Sirasiz Dizi");
foreach (var sayi in sayiDizisi)
Console.WriteLine(sayi);

Console.WriteLine("Sirali Dizi");
Array.Sort(sayiDizisi);

foreach (var sayi in sayiDizisi)
Console.WriteLine(sayi);

//Clear
Console.WriteLine("Array Clear");
//sayi dizisi elemanlarini kulllanrak 2.indexten itibaren 2 tane elemani 0lar
Array.Clear(sayiDizisi,2,2);
foreach (var sayi in sayiDizisi)
Console.WriteLine(sayi);

//Reverse
Console.WriteLine("Array Reverse");
//Listedeki siralama tersine cevrilir
Array.Reverse(sayiDizisi);
foreach (var sayi in sayiDizisi)
Console.WriteLine(sayi);


//Inexof
Console.WriteLine("Index Of");
Console.WriteLine(Array.IndexOf(sayiDizisi,23));

//Resize 
Console.WriteLine("Array Resize");
Array.Resize<int>(ref sayiDizisi,9);
sayiDizisi[8]=99;
foreach (var sayi in sayiDizisi)
Console.WriteLine(sayi);


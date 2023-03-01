namespace Algorithm
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Algorithm Programss");

            //PermutationsOfString permute = new PermutationsOfString();
            //permute.Display();

            //BinarySearch binarySearchWord = new BinarySearch();
            //binarySearchWord.Display();

            //InsertionSort insertionSort = new InsertionSort();
            //insertionSort.Insertion();

            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.Bubble();

            //MergeSort mergeSort = new MergeSort();
            //mergeSort.Display();

            //Anagram anagram = new Anagram();
            //anagram.anagram();

            //PrimeRange primesRange = new PrimeRange();
            //primesRange.Prime();

            //FindYourNumber findYourNumber = new FindYourNumber();
            //findYourNumber.Find();

            //GenericsSearchAndSort sort= new GenericsSearchAndSort();

            int[] array = { 78, 55, 45, 98, 13 };

            GenericsSearchAndSort.BubbleSort(array);


        }
    }
}
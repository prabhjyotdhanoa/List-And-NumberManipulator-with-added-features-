using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTest
{
    public partial class Form1 : Form
    {
        #region Global Variable

        List<double> numberList = new List<double>();

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            numberList.Add(number);
            numberListBox.Items.Add(number);
        }
        private void prime_Button_Click(object sender, EventArgs e)
        {
            if (IsItPrime(Convert.ToDouble(textBox1.Text)))
            {
                outputBox.Text = "Yes, " + textBox1.Text + " is Prime";
            }
            else
            {
                outputBox.Text = "No, " + textBox1.Text + " is not Prime";
            }

        }

        private void stupidSort_Button_Click(object sender, EventArgs e)
        {
            List<double> stupidList = StupidSort(numberList);
            numberListBox.Items.Clear();
            for(int i = 0; i < stupidList.Count; i++)
            {
                numberListBox.Items.Add(stupidList[i]);
            }
        }

        private void BubbleSort_Click(object sender, EventArgs e)
        {
            List<double> BubbleList = BubbleListSort(numberList);
            numberListBox.Items.Clear();
            for (int i = 0; i < BubbleList.Count; i++)
            {
                numberListBox.Items.Add(BubbleList[i]);
            }
        }
        private void InsertionSortButton_Click(object sender, EventArgs e)
        {
            List<double> InsertionList = InsertionSort(numberList);
            numberListBox.Items.Clear();
            for (int i = 0; i < InsertionList.Count; i++)
            {
                numberListBox.Items.Add(InsertionList[i]);
            }
        }
        private void DiscriminantButton_Click(object sender, EventArgs e)
        {

        }

        private void SumOfNFromIItems_Butotn_Click(object sender, EventArgs e)
        {
            
        }
        private void SumOfNItems_Button_Click(object sender, EventArgs e)
        {

            double n = Convert.ToDouble(textBox1.Text);
            double sum = sumOfnItemsList(numberList, n);

            if (!(double.IsNaN(sum)))
            {
                outputBox.Text = "The sum of the first 'n' items in the list is " + sum.ToString();
            }

            else
            {
                outputBox.Text = "PLease enter an n value less than (or equal to) the number of values in the list ";
            }

        }
        private void Reverse_button_Click(object sender, EventArgs e)
        {
            reverseList(numberList);

            numberListBox.Items.Clear();
            for (int i = 0; i < numberList.Count; i++)
            {
                numberListBox.Items.Add(numberList[i]);
            }
        }
        private void ListToNum_Button_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(textBox1.Text);

            List<char> valueList = IntegerToList(value);

            numberListBox.Items.Clear();

            for (int i = 0; i < valueList.Count; i++)
            {
                numberListBox.Items.Add(valueList[i]);
            }
        }
        private void HarmonicMean_Click(object sender, EventArgs e)
        {
            List<double> list = new List<double>(numberList);
            double answer = HarmonicMeanMethod(list);
            outputBox.Text = answer.ToString();
        }
        private void OddLIstButton_Click(object sender, EventArgs e)
        {
            List<double> list = OddList(numberList);
            numberListBox.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                numberListBox.Items.Add(list[i]);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<double> List = CocktailSort(numberList);
            numberListBox.Items.Clear();
            for (int i = 0; i < List.Count; i++)
            {
                numberListBox.Items.Add(List[i]);
            }
        }
        private void Rotate_List_Button_Click(object sender, EventArgs e)
        {
            int rotations = Convert.ToInt32(textBox1.Text);
            List<double> list = RotateList(numberList, rotations);
            numberListBox.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                numberListBox.Items.Add(list[i]);
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {

        }


        #region Procedure

       private static List<string> EnglishToPigLatin (List<string>)

       private static List<double> RotateList (List<double> List, int rotations)
        {

            if (rotations == 0)
            {
                return List;
            }
            else if (rotations > 0)
            {
                List<double> subList = new List<double>();
                int count = List.Count;

                for (int i = count-1; i > rotations+1; i=i-1)
                {
                    subList.Add(List[i]);
                }

                for (int i = 0; i < subList.Count; i++)
                {
                    List.Add(subList[i]);
                }

                return List;
            }
            else
            {
                return List;
            }
            
        }

       private static List<char> IntegerToList (int number)
        {
            string numberText = number.ToString();

            List<char> numberList = new List<char>();

            for (int i = 0; i < numberText.Length; i++)
            {
                numberList.Add(numberText[i]);
            }

            return numberList;
        }

       private static List<double> MergeTwoList (List<double> a, List<double> b)
        {
           for(int i = 0; i < b.Count; i++)
            {
                a.Add(b[i]);
            }

            return (BubbleListSort(a));
        }

       private static List<double> AlternatingMergeList (List<double> ListOne, List<double> ListTwo)
        {
            if (ListOne.Count == ListTwo.Count)
            {
                List<double> finalList = new List<double>();
                for (int i = 0; i < ListOne.Count; i++ )
                {
                    finalList.Add(ListOne[i]);
                    finalList.Add(ListTwo[i]);

                }

                return finalList;
            }
            else
            {
                return ListOne;
            }
        }

       private static void reverseList (List<double> numberList)
        {
           int count = numberList.Count;

           for (int i = 0; i < count; i++) 
            {
                numberList.Insert(i, numberList[count - 1]);
                numberList.RemoveAt(count);
            }
        }

        /*private static void reverseV1 (List <double> numberList)
         * {
         *      for (int i = 0; i < numberList.Count/2; i++)
         *      {
         *          double copy = numberList[i];
         *          numberList[i] = numberList[numberList[numberList.Cunt-1-i]];
         *          numberList[numberList.Count-1-i] = copy;
         *      }
         * }
         */

        /*private static void reverseAnush (List <double> numberList)
         * {
         *      int count = numberList.Count;
         *      for (int i = count-2; i > -1; i--)
         *      {
         *          numberList.Add(numberList[i]);
         *          numberList.RemoveAt(Count-2);
         *      }
   
         * 
         */


       private static double sumOfnItemsList (List<double> numberList, double numOfItems)
        {
            double sum = 0;
            if (numOfItems > numberList.Count || numOfItems < 0)
            {
                return double.NaN;
            }


            for (int i = 0; i < numOfItems; i++)
            {
                sum += numberList[i];

            }

            return sum;
        }

        private static double sumOfnItemsFromIList(List<double> numberList, double numOfItems, int startingIndex )
        {
            double sum = 0;

            for (int i = startingIndex; i < numOfItems+startingIndex; i++)
            {
                sum += numberList[i];

            }

            return sum;
        }

        private static List<double> CocktailSort (List <double> numberList)
        {
            List<double> sortedList = new List<double>(numberList);
            int start = 0;
            int end = sortedList.Count - 1;
            bool sorted = false;

            while (!sorted)
            {
                sorted = true;

                for (int i = start; i < end; i++)
                {
                    if (sortedList[i] > sortedList[i + 1])
                    {
                        double copy = sortedList[i];
                        sortedList[i] = sortedList[i + 1];
                        sortedList[i + 1] = copy;
                        sorted = false;
                    }
                }

                end = end - 1;


                for (int i = end; i >= start; i--)
                {
                    if (sortedList[i] > sortedList[i + 1])
                    {
                        double copy = sortedList[i];
                        sortedList[i] = sortedList[i + 1];
                        sortedList[i + 1] = copy;
                        sorted = false;
                    }
                }

                start = start + 1;
            }

            return sortedList;

        }

        private static List<double> InsertionSort (List <double> numberList)
        {
            List<double> SortedList = new List<double>(numberList);

            for (int i = 1; i < numberList.Count; i++)
            {
                double marker = SortedList[i];
                int previous = i - 1;

                while (previous >= 0 && SortedList[previous]> marker)
                {
                    SortedList[previous + 1] = SortedList[previous];
                    previous = previous - 1;
                }
                SortedList[previous + 1] = marker;
            }
            return SortedList;   
        }

        private static List<double> StupidSort( List<double> ListOfNumbers)
        {
            List<double> SortedList = new List<double>(ListOfNumbers);

            int index = 0;

            while (index < ListOfNumbers.Count)
            {
                if (index == 0 || SortedList[index] > SortedList[index - 1])
                {
                    index = index + 1;
                }
                else
                {
                    double Swap = SortedList[index - 1];

                    SortedList[index - 1] = SortedList[index];
                    SortedList[index] = Swap;

                    index = index - 1;

                     
                }
            }

            return SortedList;
        }

        private static List<double> OddList (List<double> List)
        {
            List<double> numberList = new List<double>();

            for (int i = 0; i < List.Count; i++)
            {
                if (i % 2 != 0)
                {
                    numberList.Add(List[i]);
                }
            }

            return numberList;
        }

        private static List<double> BubbleListSort (List<double> numberList)
        {
            int index = 0;
            int loopNumber = (numberList.Count - 1);

            for (int x = 0; x < loopNumber; x++)
            {
                index = 0;
                while (index < numberList.Count)
                {
                    if (index == 0 || numberList[index]>numberList[index-1])
                    {
                        index++;
                    }
                    else if (numberList[index]<numberList[index-1])
                    {
                        double copy = numberList[index];
                        numberList[index] = numberList[index - 1];
                        numberList[index - 1] = copy;
                        index++;
                    }
                }
            }
            return numberList;
        }

        private static bool IsItPrime(double number)

        {
            if (number == 2)
            {
                return true;
            }

            if (number <= 1)
            {
                return false;
            }
            //Dev took out useless code

            int RootOfNumber = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= RootOfNumber; i ++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;

        }

        private static double HarmonicMeanMethod(List<double> numberList)
        {
            if (numberList.Count == 0)
            {
                return double.NaN;
            }
            else
            {
                double sumOfList = 0;
                for (int i = 0; i < numberList.Count; i++)
                {
                    if (numberList[i] <= 0)
                    {
                        return double.NaN;
                    }
                    else
                    {
                        sumOfList += (1 / numberList[i]);
                    }
                }
                return (numberList.Count / sumOfList);
            }
        }

    }
}
#endregion
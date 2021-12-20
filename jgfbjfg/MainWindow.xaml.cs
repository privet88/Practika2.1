using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LibMas;
using Lib10;
using System.IO;
using Microsoft.Win32;
using Practika2;

namespace jgfbjfg
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int[] mas;//описываем массив как глобальный элемент
        private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            int indexColumn = e.Column.DisplayIndex;//определяем номер ячейки
            mas[indexColumn] = Convert.ToInt32(((TextBox)e.EditingElement).Text);//заносим полученное значение в массив

        }
        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Создать_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int count = Convert.ToInt32(ColumnCount.Text);//определяем количество ячеек в массиве
                Class2.CreateArray(out mas, count);//используем функцию для создания массива
                dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;//выводим массив на форму
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Заполнить_Click(object sender, RoutedEventArgs e)
        {
            int randMax = Convert.ToInt32(diapazon.Text);//определяем диапозон случайных чисел
            int count = Convert.ToInt32(ColumnCount.Text);//определяем количество ячеек в массиве
            Class2.InitArray(out mas, count, randMax);//используем функцию
            dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;//выводим массив на форму
        }

        private void Решение_Click(object sender, RoutedEventArgs e)
        {
            Massiv.Radikal(mas, out string s1);//используем функцию
            rez.Text = s1;//выводим результат вычислений
        }

        private void Очистить_Click(object sender, RoutedEventArgs e)
        {
            Class2.CleanArray(ref mas);//используем функцию для очистки массива
            dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;//выводим массив на форму
        }
        private void Сброс_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;//очищаем таблицу
            mas = null;//очищаем массив
            rez.Clear();//очищаем результаты вычислений
            diapazon.Clear();//очищаем диапозон случайных чисел
            ColumnCount.Clear();//очищаем количество ячеек
        }

        private void Сохранить_Click(object sender, RoutedEventArgs e)
        {
            Class2.SaveArray(mas);//используем функцию для сохранения
        }

        private void Открыть_Click(object sender, RoutedEventArgs e)
        {
            Class2.OpenArray(out mas);//используем функцию для открытия
            dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;//выводим массив на форму
        }

        private void Опрограмме_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Потапкин Павел Исп-31. Задание:Ввести n целых чисел. Вычислить для чисел > 0 функцию x.Результат обработкикаждого числа вывести на экран");
        }
    }
}

    


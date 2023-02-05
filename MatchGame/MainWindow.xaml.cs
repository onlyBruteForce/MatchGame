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

namespace MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            // Создаем список эмоджи
            List<string> animals = new List<string>()
            {
                "👹","👹",
                "👺","👺",
                "💀","💀",
                "🐱","‍🐱‍",
                "🦁","🦁",
                "🦍","🦍",
                "🐆","🐆",
                "😶","😶",
            };
            Random random = new(); // создаем генератор случайных чисел
            foreach (TextBlock textBlock in Choice.Children.OfType<TextBlock>())
                /* для каждого элемента в текстовом блоке TextBlock
                 * выполняем следующую последовательность действий */

            {
                // объявляем переменную index и инициализируем ее случайным числом от 0 до количества эмоджи в списке
                int index = random.Next(animals.Count);
                // объявляем переменную nextEmoji и храним в ней эмоджи из нашего списка со случайным номером index
                string nextEmoji = animals[index];
                // Помещаем в TextBlock случайный эмоджи
                textBlock.Text = nextEmoji;
                // удаляем случайно выбранный нами эмоджи из списка
                animals.RemoveAt(index);
            }
        }
    }
}

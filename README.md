# Условие задачи

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

# Описание решения задачи 

*В решении предусматривается на выбор пользователя использовать заданный массив или ввести массив с клавивтуры. После окончания задачи предлагается повторить решение.*

## Для решения задачи используем следующий алгоритм: 

1. В случае выбора пользователем ввода массива с клавиатуры вводится размерность массива, а затем элементы массива.
2. Элементы, удовлетворяющие условию поставленной задачи, будем фиксировать в новом массиве.
3. Далее решение не отличается для двух случаев. Открывается цикл со счетчиком __от 0 до length__ (*где length - длина массива*), и длина каждого элемента массива сравнивается с 3.
4. В случае, если текущий элемент массива меньше или равен 3, то в заданную ранее переменную __changeSize__ добавляем 1. Это необходимо для опрпеделения размера нового массива.
5. Если __changeSize__ равно 0, то выводим сообщение о том, что в данном массиве нет элемнтов, длина которых меньше или равна 3.
6. В остальных случаях снова открываем цикл со счетчиком __от 0 до length__.
7. Внутри этого цикла открываем дополнительный цикл со счетчиком __от count до length__ и снова сравниваем элементы массива с 3.
8. Переменная __count__ принимает начальное значение равное 0, а затем в процессе прохождения цикла увеличивается на 1 вместе с увеличением счетчика вложенного цикла. В случае, когда элемент исходного массива удовлетворяет условию задачи, его значение присваевается элементу нового массива, вложенный цикл прерывается, увеличивается счетчик внешнего цикла, а вложенный цикл начинается со значения __count__.
9. В итоге получается массив с элементами, длина которых меньше или равна 3.
10. Новый массив выводится на экран.

__*Примечания:*__

* в решении использованы методы для заполнения массива, для вывода массива на экран и для поиска элементов, удовлетворяющих условиям задачи;

* в начале пользователю предложено выбрать, какой массив будет использован в качестве исходного с помощью оператора _**switch-case**_;

* после окончания решения задачи пользователю предлагается повторить решение задачи или отказаться с помощью оператора __*switch-case*__;

* в блок-схеме последний шаг кода (повтор решения задачи) не представлен.
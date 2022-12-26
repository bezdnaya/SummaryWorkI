# SummaryWorkI
## Привет! Меня зовут Ирина! И это мое первое итоговое задание после обучения в 1 четверти в Geek brains. 
Задание было: 
* Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше или равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Для начала я создала первоначальный массив из которого будут браться элементы для второго массива. Так как вводить элементы с клавиатуры это муторное занятие, я облегчила участь пользователя тем, что программа сама создаёт этот массива из случайного количества элементов. Cами элементы состоят из случайного количества разных букв, который взят из массива Baza. \
Ах да, массив Baza это просто массив из букв английского алфавита. \
Вот массив из разных элементов готов. Теперь нам нужно перебрать каждый элемент массива и посчитать количество букв в элементе. Если длина элемента меньше 4, то мы этот элемент записываем в новый пустой массив. \
Все элементы перебраны, пора выводить результирующий массив на экран.
### Проблемы, с которыми я столкнулась.
* Первая проблема, над которой мне пришлось задуматься, это как сделать так чтобы элементы в первом массиве содержали элементы, длиной больше 1 буквы. Для решения этого вызова я создала 2 цикла. Первый "щёлкает" элементы в массиве. Второй внутри первого "щёлкает" буквы внутри элемента, каждый раз добавляя случайную букву из массива Baza. 
* Вторая проблема это то, что мы не знаем длину второго массива. Для решения этой преблемы, я воспользовалась методом Array.Resize, который каждую итерацию после прохождения проверки элемента на длину, меняет длину массива, добавляя +1 к длине.
* Ограничение не использовать коллекцию вовсе не оказалось проблемой, так как я даже не знаю что это такое и с удовольствием использовала массивы.
## На этом всё!

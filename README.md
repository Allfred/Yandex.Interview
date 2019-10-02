# Yandex.Interview
Решенные задачи Яндекса в разделе Яндекс.Интервью на языке C#

-------

A. Камни и украшения

Ограничение времени:	1 секунда.

Ограничение памяти:	64Mb.

Ввод:	стандартный ввод или input.txt.

Вывод: стандартный вывод или output.txt


Даны две строки строчных латинских символов: строка J и строка S. Символы, входящие в строку J, — «драгоценности», входящие в строку S — «камни». Нужно определить, какое количество символов из S одновременно являются «драгоценностями». Проще говоря, нужно проверить, какое количество символов из S входит в J.
Это разминочная задача, к которой мы размещаем готовые решения. Она очень простая и нужна для того, чтобы вы могли познакомиться с нашей автоматической системой проверки решений. Ввод и вывод осуществляется через файлы, либо через стандартные потоки ввода-вывода, как вам удобнее.

Формат ввода
На двух первых строках входного файла содержатся две строки строчных латинских символов: строка J и строка S. Длина каждой не превосходит 100 символов.

Формат вывода
Выходной файл должен содержать единственное число — количество камней, являющихся драгоценностями.

-------

B. Последовательно идущие единицы

Ограничение времени:	1 секунда.

Ограничение памяти:	64Mb.

Ввод:	стандартный ввод или input.txt.

Вывод: стандартный вывод или output.txt

Требуется найти в бинарном векторе самую длинную последовательность единиц и вывести её длину.

Желательно получить решение, работающее за линейное время и при этом проходящее по входному массиву только один раз.

Формат ввода:

Первая строка входного файла содержит одно число n, n ≤ 10000. Каждая из следующих n строк содержит ровно одно число — очередной элемент массива.

Формат вывода:

Выходной файл должен содержать единственное число — длину самой длинной последовательности единиц во входном массиве.

------------

C. Удаление дубликатов

Ограничение времени:	1 секунда.

Ограничение памяти:	10Mb.

Ввод:	стандартный ввод или input.txt.

Вывод: стандартный вывод или output.txt

Дан упорядоченный по неубыванию массив целых 32-разрядных чисел. Требуется удалить из него все повторения.

Желательно получить решение, которое не считывает входной файл целиком в память, т.е., использует лишь константный объем памяти в процессе работы.

Формат ввода
Первая строка входного файла содержит единственное число n, n ≤ 1000000.

На следующих n строк расположены числа — элементы массива, по одному на строку. Числа отсортированы по неубыванию.

Формат вывода
Выходной файл должен содержать следующие в порядке возрастания уникальные элементы входного массива.

------

D. Генерация скобочных последовательностей

Ограничение времени:	1 секунда.

Ограничение памяти:	20Mb.

Ввод:	стандартный ввод или input.txt.

Вывод: стандартный вывод или output.txt

Дано целое число n. Требуется вывести все правильные скобочные последовательности длины 2 ⋅ n, упорядоченные лексикографически (см. https://ru.wikipedia.org/wiki/Лексикографический_порядок).

В задаче используются только круглые скобки.

Желательно получить решение, которое работает за время, пропорциональное общему количеству правильных скобочных последовательностей в ответе, и при этом использует объём памяти, пропорциональный n.

Формат ввода
Единственная строка входного файла содержит целое число n, 0 ≤ n ≤ 11

Формат вывода
Выходной файл содержит сгенерированные правильные скобочные последовательности, упорядоченные лексикографически.

![alt text](https://sun9-60.userapi.com/c852032/v852032814/1cf53b/RYEML6R7KJU.jpg)


-----------------

E. Анаграммы

Ограничение времени:	1 секунда.

Ограничение памяти:	20Mb.

Ввод:	стандартный ввод или input.txt.

Вывод: стандартный вывод или output.txt

Даны две строки, состоящие из строчных латинских букв. Требуется определить, являются ли эти строки анаграммами, т. е. отличаются ли они только порядком следования символов.

Формат ввода
Входной файл содержит две строки строчных латинских символов, каждая не длиннее 100 000 символов. Строки разделяются символом перевода строки.

Формат вывода
Выходной файл должен содержать единицу, если строки являются анаграммами, и ноль в противном случае.

-----
F. Слияние k сортированных списков

Ограничение времени:	1 секунда.

Ограничение памяти:	10Mb.

Ввод:	стандартный ввод или input.txt.

Вывод: стандартный вывод или output.txt

Даны k отсортированных в порядке неубывания массивов неотрицательных целых чисел, каждое из которых не превосходит 100. Требуется построить результат их слияния: отсортированный в порядке неубывания массив, содержащий все элементы исходных k массивов.

Длина каждого массива не превосходит 10 ⋅ k.

Постарайтесь, чтобы решение работало за время k ⋅ log(k) ⋅ n, если считать, что входные массивы имеют длину n.

Формат ввода
Первая строка входного файла содержит единственное число k, k ≤ 1024.

Каждая из следующих k строк описывает по одному массиву. Первое число каждой строки равняется длине соответствующего массива, оставшиеся числа этой строки описывают значения элементов этого же массива. Элементы массивов являются неотрицательными целыми числами и не превосходят 100.

Формат вывода
Выходной файл должен содержать отсортированный в порядке неубывания массив, содержащий все элементы исходных массивов.

![alt text](https://sun9-34.userapi.com/c852032/v852032814/1cf555/XXjj8C8L6Fo.jpg)

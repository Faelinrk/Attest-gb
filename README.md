# Аттестация

## Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
## Решение:
Для того, чтобы создать массив подходящей длины я использовал метод CountNumEnements.
Он принимает исходный массив и количество символов в элементе. После того, как с помощью цикла for он проходится по всему этому массиву, он подсчитывает количество элементов с указанной длиной. Это и будет длина нашего нового массива.
#
Чтобы создать новый массив, я создал метод FilterArrayToArray. Он так же принимает исходный массив и количество символов в элементе для фильтрации.
В нём создаётся новый массив указанной длины и в него добавляются объекты, не превышающую длину, принятую в параметре.
#
Для того, чтобы распечатать массивы был создан метод PrintArray. Он принимает массив, который нужно распечатать и проходится по каждому из элементов внутри него с помощью цикла for.
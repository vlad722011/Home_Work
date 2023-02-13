# Home_Work
## Алгоритм решения задачи - следующий:

*Первым делом получаем от пользователя входные данные.*

*В нашем случае, это будет целое число, которому будет равна длина входящего массива.*

*Далее просим пользователя ввести строки - элементы входящего массива.*

 *Само решение задачи собственно состоит из нескольких простых шагов.*

 ### Шаг №1.

 *В отдельном методе мы находим длину будущего массива, который нам необходимо получить. Для этого вводим целочисленную переменную счетчик, присваиваем ей значение равное нулю. И далее пробегаемся по элементам входящего массива, и смотрим их длинну. Если длина элемента массива меньше или равна трем символам, значение счетчика увеличиваем на единицу. На выходе мы получим число - длину искомого массива.*

 ### Шаг №2.

 *В следующем методе создается новый массив нужной длины, и вновь пробегаясь в цикле по входящему массиву, мы смотрим на длину элементов входящего массива. Если длина элемента меньше или равна трем символам, то данный элемент массива заносится в элемент нового искомого массива под нужным индексом. Для этого в самом начале метода переменная счетчик обнуляется, и после каждого нужного нам элемента, записываемого в искомый массив, значение счетчика увеличивается на единицу.  Именно эта переменная счетчик и показывает под каким номером индекса необходимо в новый массив записывать подходящую строку. Пробежавшись по всему входящему массиву, мы в конце получим полностью заполненый искомый массив, который и выведем на печать.*

  ### Шаг №3.
 
 *Выводим массивы на печать. Для вывода на печать массивов, как входящего, так и искомого, используется отдельный метод.*
# Описание программы
## Программа представлена двумя блоками:
1. Создается массив строк для анализа. Размер массива вводится с консоли. Минимальное и максимальное значение длины строки также вводится с консоли. Длина каждой строки определяется случайным образом с использованием генератора случайных чисел. Созданный массив строк выводится на консоль
2. Методом перебора элементов массива строк определяются строки длины меньше 4 и записываются в новый массив. Новый массив выводится на консоль непосредственно под исследованным массивом.

## Функциональное описание программы:
### `int anyNumberInput()`: эта функция предлагает пользователю ввести натуральное число с консоли. Также она проверяет, представляет ли введенная строка число. Запрос повторяется до тех пор, пока не будет введено натуральное число.
Разберем код шаг за шагом:
1. `int AnyNumberInput()`: данная функция не принимает параметров и возвращает целое число.

2. ` while (true)`: инициирует бесконечный цикл, гарантируя, что функция будет продолжать запрашивать пользователя до тех пор, пока не будет предоставлен ввод натурального числа.

3. Запрос на ввод данных пользователем:
    - Внутри цикла функция выводит на консоль сообщение «Введите неотрицательное число» (Введите неотрицательное целое число), предлагая пользователю ввести число.

4. Чтение пользовательского ввода:
    - `string inputString = Console.ReadLine()!;`: эта строка считывает вводимые пользователем данные с консоли и сохраняет их в виде строки в переменной `inputString`. Оператор `!` используется для исключения значений NULL, поскольку `ReadLine()` может вернуть `NULL`, если достигнут конец входного потока.

5. Проверка ввода:
    - Функция перебирает каждый символ входной строки, используя цикл for (`for (int i = 0; i < inputString.Length; i++)`).

    - Внутри цикла она проверяет каждый символ, чтобы убедиться, что он представляет цифру. Для выполнения этой проверки используются значения ASCII символов от 0 до 9.

    - Если первый символ равен «0», это гарантирует, что это единственный символ в строке (что указывает на допустимый нулевой ввод).

    - Если какой-либо символ не является цифрой (от «0» до «9») или если первый символ равен «0» и есть дополнительные символы, цикл прерывается, указывая на недопустимый ввод.

    - Если цикл завершается без прерывания, то есть все символы являются допустимыми цифрами, он возвращает целочисленное представление входной строки с помощью Convert.ToInt32(inputString)`.

6. Функция продолжает выполняться бесконечно, пока не будет предоставлен действительный вход.

Таким образом, эта функция постоянно предлагает пользователю ввести неотрицательное целое число с консоли. Она проверяет ввод, чтобы гарантировать, что он состоит только из цифр, и возвращает целочисленное значение входной строки. Она выполняется бесконечно, пока не будет получен действительный ввод.

### `string[] CreateDifferenceLengthStringArray(int arraySize, int minStringSize, int maxStringSize, string stringSource)`: эта функция генерирует массив строк заданного размера (`arraySize`), где каждая строка в массиве имеет случайную длину между ` minStringSize` и `maxStringSize`. Символы для построения этих строк взяты из строки stringSource.

Эта функция генерирует случайный массив строк различной длины. Разберем код шаг за шагом:

1. `string[] CreateDifferenceLengthStringArray(int arraySize, int minStringSize, int maxStringSize, string stringSource)`: эта функция принимает четыре параметра:
    - `arraySize`: Желаемый размер создаваемого массива строк.
    - `minStringSize`: минимальная длина каждой строки в массиве.
     - `maxStringSize`: максимальная длина каждой строки в массиве.
     - `stringSource`: строка, содержащая символы, из которых будут формироваться случайные строки.

2. `string[] array = new string[arraySize];`: эта строка инициализирует новый массив строк с указанным размером `arraySize`.

3. `Random rnd = new Random();`: здесь создается новый экземпляр класса `Random`. Этот экземпляр будет использоваться для генерации случайных чисел.

4. `for (int i = 0; i < arraySize; i++)`: этот цикл перебирает каждый элемент массива строк.

5. `int RandomStrinSize = Convert.ToInt32(rnd.Next(minStringSize, maxStringSize + 1));`: внутри цикла генерируется случайное целое значение между `minStringSize` и `maxStringSize  используя метод Next класса Random. Это случайное значение представляет длину строки, которая будет сгенерирована для текущего элемента массива.

6. `for (int j = 0; j < RandomStrinSize; j++)`: внутри внешнего цикла инициируется другой цикл для генерации символов для строки.

7. `int indexStringSource = Convert.ToInt32(rnd.Next(0, stringSource.Length));`: внутри внутреннего цикла генерируется случайный индекс для выбора символа из `stringSource`. Метод Next генерирует случайное целое число от 0 до длины stringSource -1.

8. `array[i] += stringSource[indexStringSource];`: эта строка добавляет случайно выбранный символ из `stringSource` к текущей строке в массиве.

9. После завершения выполнения обоих циклов для всех элементов массива функция возвращает результирующий строковый массив.

Эта функция по существу создает массив строк, где каждая строка имеет случайную длину в пределах указанного диапазона (от minStringSize до maxStringSize) и создается путем случайного выбора символов из stringSource.

### `void PrintArray(string[] array)`: эта функция выводит содержимое массива строк на консоль.

### `int amountMemberArrayLessThanThree(string[] array, int Criteria)`: данная функция вычисляет количество строк в заданном массиве, длина которых меньше или равна указанному критерию ("Criteria"). Она перебирает элементы массива и просчитывает соответствующие строки.
Разберем код шаг за шагом:

1. `int amountMemberArrayLessThanThree(string[] array, int Criteria)`: эта функция принимает два параметра:
 - `array`: массив строк.
 - `Criteria`: целое число, представляющее максимально допустимую длину строки в массиве.

2. `int k = 0;`: инициализирует переменную `k` нулем. `k` будет использоваться для подсчета количества строк в массиве, соответствующих критерию.

3. `for (int i = 0; i < array.Length; i++)`: этот цикл перебирает каждый элемент входного массива `array`.

4. `if (array[i].Length <= Criteria)`: внутри цикла проверяется, является ли длина текущей строки (`array[i].Length`) меньше или равна указанному `Criteria `.

5. `k = k + 1;`: если длина текущей строки соответствует критериям, счетчик `k` увеличивается на единицу.

6. После прохода по всем элементам массива функция возвращает конечное значение `k`, которое представляет собой количество строк в массиве, удовлетворяющих условию длины.

Таким образом, эта функция обеспечивает простой способ определить количество строк в массиве, длина которых меньше или равна заданному критерию. Он перебирает каждую строку в массиве, проверяет ее длину и увеличивает счетчик, если длина соответствует указанным критериям. Наконец, она возвращает количество подходящих строк.

### `string[] arrayFiltred(string[] array, int cond, int k)`: эта функция фильтрует входной массив на основе условия (`cond`) по длине строки. Он создает новый массив, содержащий только строки, соответствующие условию. Он также заменяет строки, не соответствующие условию, пробелами в исходном массиве. Затем он выводит на консоль исходный и отфильтрованный массивы.

1. `string[] arrayFiltred(string[] array, int cond, int k)`: эта функция принимает три параметра:
 - `array`: входной массив строк для фильтрации.
 - `cond`: целое число, представляющее условие максимально допустимой длины строк в фильтруемом массиве.
 - `k`: целое число, представляющее количество строк в отфильтрованном массиве (определенное предыдущим вычислением).

2. `string[] arrayF = new string[k];`: эта строка инициализирует новый массив строк `arrayF` с размером `k`, который представляет количество строк во входном массиве, соответствующих условию длины.

3. `if (k == 0)`: это условие проверяет, нет ли во входном массиве строк, удовлетворяющих условию длины (`k == 0`), указывая, что отфильтрованный массив будет пустым.

4. Внутри блока `if` на консоль выводится сообщение о том, что в массиве нет строк с длиной меньше или равной заданному критерию. Затем возвращается пустой массив arrayF.

5. `int j = 0;`: эта переменная `j` инициализируется нулем. Он будет использоваться в качестве индекса для заполнения отфильтрованного массива arrayF.

6. Функция перебирает каждый элемент входного массива, используя цикл for.

7. `if (array[i].Length <= cond)`: внутри цикла проверяется, меньше ли длина текущей строки (`array[i].Length`) заданному условию ( `cond`).

8. Если условие выполнено, текущая строка добавляется в отфильтрованный массив ArrayF по индексу j, а индекс j увеличивается.

9. Если условие не выполнено, текущая строка в исходном массиве заменяется строкой, содержащей пробелы той же длины. 

10. После перебора всех элементов входного массива функция выводит на консоль трансформированный массив («array») и отфильтрованный массив («arrayF») с помощью функции PrintArray с аттрибутивными комментариями к этим массивам. 

11. В качестве результата возвращается отфильтрованный массив arrayF.

Таким образом, данная функция создает новый массив, содержащий только те строки из входного массива, которые удовлетворяют условию длины. Он также изменяет исходный массив, заменяя строки, не соответствующие условию, пробелами и выводит на консоль под значениями исходного нетрансформированного массива для лучшей визуализации того какие элементы удовлетворяют условию длины.

### `int inputArrayMaxStringSize(int minStringSize)`: функция предлагает пользователю ввести максимально допустимую длину строк в массиве, задавая, что она должна быть больше или равна минимальному размеру строки.

1. `int inputArrayMaxStringSize(int minStringSize)`: эта функция принимает один параметр:
 - `minStringSize`: целое число, представляющее минимально допустимую длину строк в массиве.

2. `int MaxStringSize = minStringSize - 1;`: эта строка инициализирует переменную `MaxStringSize` значением, меньшим минимального размера строки. Это гарантирует, что цикл while выполнится хотя бы один раз.

3. Функция входит в цикл while, который продолжает выполняться до тех пор, пока минимальный размер строки (minStringSize) превышает рассчитанный максимальный размер строки (MaxStringSize). Этот цикл гарантирует, что пользователь вводит допустимый максимальный размер строки, который больше или равен минимальному размеру.

4. Внутри цикла:
 - Консоль предлагает пользователю ввести максимально допустимую длину строк в массиве.
 - Функция AnyNumberInput() вызывается для получения пользовательского ввода. Предполагается, что эта функция обрабатывает пользовательский ввод и гарантирует, что он представляет допустимое целое число.
 — Входное значение присваивается MaxStringSize.
 - На консоль выводится сообщение, подтверждающее введенный пользователем номер.

5. Как только пользователь ввел допустимый максимальный размер строки, соответствующий условию, функция выходит из цикла и возвращает максимальный размер строки.

Таким образом, эта функция гарантирует, что пользователь предоставляет допустимую максимально допустимую длину строк в массиве, гарантируя, что она больше или равна указанному минимальному размеру. Она продолжает запрашивать пользователя до тех пор, пока не будет произведен ввод корректного значения.

### `string[]randomArrayBilding()`: эта функция управляет генерацией массива случайных строк. Пользователь вводит размер массива, минимальный размер строки и максимальный размер строки. Затем он генерирует массив с помощью CreateDifferenceLengthStringArray, печатает его и возвращает.

1. `string[] randomArrayBilding()`: эта функция не принимает параметров и возвращает массив строк.

2. `string stringSource = "1234567890qwertyuiop[]\asdfghjkl;'zxcvbnm,./!@#$%^&*()_+-=~`";`: эта строка инициализирует строку `stringSource`, содержащую набор персонажи. Эти символы будут использоваться для генерации случайных строк для массива.

3. Пользовательский ввод:
 - Функция предлагает пользователю ввести размер массива строк, выведя на консоль «Введите размер строки массива».
 - Затем он вызывает функцию AnyNumberInput(), чтобы получить введенные пользователем данные о размере массива. Эта функция гарантирует, что входные данные являются допустимым целым числом.
 - Введенное значение сохраняется в переменной arraySize.

4. Функция предлагает пользователю ввести минимально допустимую длину строк в массиве, выведя на консоль «Введите МИНИМАЛЬНО возможную длину строки».
 - Он снова вызывает функцию AnyNumberInput(), чтобы получить ввод пользователя для минимального размера строки. Это гарантирует, что входные данные являются допустимым целым числом.
 - Введенное значение сохраняется в переменной minStringSize.

5. Определение максимального размера строки:
 - Функция вызывает функцию inputArrayMaxStringSize, передавая минимальный размер строки в качестве аргумента, чтобы гарантировать, что пользователь предоставляет допустимый максимальный размер строки.
 — Возвращаемый максимальный размер строки сохраняется в переменной maxStringSize.

6. Генерация массива строк:
 - Функция вызывает функцию CreateDifferenceLengthStringArray, передавая в качестве аргументов размер массива, минимальный размер строки, максимальный размер строки и stringSource. Эта функция генерирует случайный массив строк на основе предоставленных параметров.
 — Полученный массив сохраняется в переменной stringArray.

7. Печать исходного массива:
 - На консоль выводится пустая строка для отступа.
 — Функция PrintArray вызывается для печати исходного массива строк («stringArray») на консоль.

8. Заключительные шаги:
 — Функция печатает сообщение «Первоначальный массив строк», указывающее, что напечатанный массив является исходным массивом.
 - Наконец, он возвращает сгенерированный массив строк («stringArray»).

Таким образом, эта функция организует генерацию случайного массива строк на основе введенных пользователем данных о размере массива, минимальном размере строки и максимальном размере строки. Она выводит исходный массив на консоль и при необходимости возвращает его для дальнейшей обработки.

### `string[] arrayFiltredBuilding(string[] stringArray, int cond)`: эта функция служит для фильтрации входного массива (`stringArray`) так, чтобы он содержал только строки, длина которых меньше или равна заданному условию (`cond` ). Он вычисляет количество подходящих строк, фильтрует массив с помощью arrayFiltred и возвращает отфильтрованный массив.

Эта функция C#, ArrayFiltredBuilding, отвечает за создание отфильтрованного массива строк на основе заданного условия (cond). Давайте разберем код:

1. `string[] arrayFiltredBuilding(string[] stringArray, int cond)`: эта функция принимает два параметра:
 - `stringArray`: массив строк для фильтрации.
 - `cond`: целое число, представляющее условие максимально допустимой длины строк в фильтруемом массиве.

2. `int arrayFiltredStringAmount = summberArrayLessThanThree(stringArray, cond);`: эта строка вычисляет количество строк во входном массиве `stringArray`, длина которых меньше или равна указанному условию `cond`. Для выполнения этого вычисления он вызывает функцию amountMemberArrayLessThanThree.

3. `string[] arrayF = arrayFiltred(stringArray, cond, arrayFiltredStringAmount);`: эта строка создает отфильтрованный массив строк (`arrayF`) путем вызова функции `arrayFiltred`. Он передает входной массив stringArray, условие cond и рассчитанное количество соответствующих строк arrayFiltredStringAmount в качестве аргументов функции arrayFiltred.

4. Наконец, функция возвращает отфильтрованный массив arrayF.

Таким образом, данная функция вычисляет количество соответствующих условиям строк, а затем использует эту информацию для создания и возврата отфильтрованного массива.

### `main program`. В основной программе с помощью `randomArrayBilding` генерируется случайный массив строк, который затем фильтруется так, чтобы он содержал строки с длиной меньше или равной 3, с помощью функции `ArrayFiltredBuilding`. Отфильтрованный массив хранится в массиве `ArrayFiltredSizeLessThree`.

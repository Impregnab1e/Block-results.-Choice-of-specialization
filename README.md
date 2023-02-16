# Final project

#### **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

### **Решение**:

**Созданы методы**:
1. *GetDrataFrom User* - получение данных от пользователя. Количество элементов в массиве;
2. *ArrayFromUser* - ввод массива;
3. *ThreeSymbolArray* - фильтрация массива по условию задачи;
4. *printArray* - для вывода массивов.

**Алгоритм**:
* Создаем массив;
* вводим массив с консоли;
* делаем подсчет количества элементов в массиве, длина которых менее 4 символа;
* создаем новый массив размером, равному количетсву подсчитанных элементов менее 4 символа;
* формируем новый массив из первоначального, длина строк которых меньше либо равна 3 символа.
* вывод первоначального и нового массива.
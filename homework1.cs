// Необходимо реализовать операцию нахождения квадратного уравнения. Предположим, что эта операция описывается следующей функцией c поправкой на конкретный язык программирования. В ООП языках эта функция реализуется в виде метода класса.
//solve(double a, double b, double c): double[]
//здесь a, b, c - коэффициенты квадратного уравнения, функция возвращает список корней квадратного уравнения.
//Написать тест, который проверяет, что для уравнения x^2+1 = 0 корней нет (возвращается пустой массив)
//Написать минимальную реализацию функции solve, которая удовлетворяет данному тесту.
//Написать тест, который проверяет, что для уравнения x^2-1 = 0 есть два корня кратности 1 (x1=1, x2=-1)
//Написать минимальную реализацию функции solve, которая удовлетворяет тесту из п.5.
//Написать тест, который проверяет, что для уравнения x^2+2x+1 = 0 есть один корень кратности 2 (x1= x2 = -1).
//Написать минимальную реализацию функции solve, которая удовлетворяет тесту из п.7.
//Написать тест, который проверяет, что коэффициент a не может быть равен 0. В этом случае solve выбрасывает исключение.
//Примечание. Учесть, что a имеет тип double и сравнивать с 0 через == нельзя.
//Написать минимальную реализацию функции solve, которая удовлетворяет тесту из п.9.
//С учетом того, что дискриминант тоже нельзя сравнивать с 0 через знак равенства, подобрать такие коэффициенты квадратного уравнения для случая одного корня кратности два, чтобы дискриминант был отличный от нуля, но меньше заданного эпсилон. Эти коэффициенты должны заменить коэффициенты в тесте из п. 7.
//При необходимости поправить реализацию квадратного уравнения.
//Посмотреть какие еще значения могут принимать числа типа double, кроме числовых и написать тест с их использованием на все коэффициенты. solve должен выбрасывать исключение.
//Написать минимальную реализацию функции solve, которая удовлетворяет тесту из п.13.
//Сделать merge request/pull request и ссылку на него указать при сдаче ДЗ.


using System;

namespace HomeWorkOne
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
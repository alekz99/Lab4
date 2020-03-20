# Lab4
creating cross app using pattern Abstract Factory

Задание: Предположим, нам надо написать кроссплатформенное приложение, которое должно запускаться на Mac OS, Windows и Ubuntu (можно выбрать любую другую ОС семейства Linux). Напишите часть приложения, отвечающую за настройку параметров. Входные данные - название ОС, выходные данные - настройки приложения. Минимальное количество изменяющихся параметров: 10.

Для решения задачи потребуется применение шаблона "Абстрактная фабрика".

Комменатрий к выполненной работе: Абстрактной фабрикой является класс AppFactory. Каждый метод этого класса возвращает интерфейс (в моей работе это: интерфейс окна, меню и пути). Есть три конкретные фабрики: Windows, Ubuntu, Mac OS. Каждый из этих классов переопределяет методы асбтрактного класса, возвращая объекты для конкретной операционной системы. То есть каждая конкретная фабрика имеет классы, которые наследуются от интефейсов, и указывают как конкретно создавать данный объект. Например, для создания окна в ОС Windows используется конкретная фабрика Windows, класс WindowsWindow, который указывает, как создавать окно под эту ОС. OrderApplication - класс формы, поля которого являются интерфейсами, т.е. класс создают элементы интерфейса. Application - класс, который создает элементы приложения под конкретную ОС. Класс по названию ОС определяет конкртеную фабрику, которую передаст в конструктор класса OrderApplication.

Работа программы:

1 Вариант Choose OS: Mac OS, Windows, Ubuntu 
Windows 
--Creating params for Windows 
--Window settings made for Windows 
----Size customized 
----4 button customized 
--Menu settings made for Windows 
----Theme 1 
--Path chosen for Windows 
----Root path for Windows customized 
The end program

2 Вариант Choose OS: Mac OS, Windows, Ubuntu 
Mac os 
--Creating params for Mac OS 
--Window settings made for Mac OS 
----Size customized 
----3 button customized 
--Menu settings made for Mac OS 
----Theme 3 
--Path chosen for Mac OS 
----Root path for Mac OS customized 
The end program

3 Вариант Choose OS: Mac OS, Windows, Ubuntu 
uBUntu 
--Creating params for Ubuntu 
--Window settings made for Ubuntu 
----Size customized 
----7 button customized 
--Menu settings made for Ubuntu 
----Theme 2 --Path chosen for Ubuntu
----Root path for Ubuntu customized 
The end program

4 Вариант При некорректном вводе выбрасывается ошибка.

Выводы: Преимущества абстрактной фабрики:

код не зависит от конкретной фабрики (в данном случае от ОС);
простое и понятное добавление новых конкретных фабрик (в данном случае ОС). Недостатки:
код быстро возрастает из-за большого количества классов (поэтому в моем пример не 10 изменяющихся параметров (что равно 30 классам реализации конкретных аттрибутов для каждой ОС));
для каждой конкретной фабрики обязательна реализация всех атрибутов (для каждой ОС нужно обязательно создать меню, путь и окно).

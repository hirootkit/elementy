## Elementors-ARM

Программа носит характер автоматизированного рабочего места (АРМ) председателя цикловой комиссии. В разработанном приложении предусмотрена возможность редактирования старых отчетов и формирования новых, организация и поддержка самостоятельной базы данных. На основе хранящейся в базе данных информации о преподавателях, дисциплинах, рейтинговых оценках этими данными легко оперировать.

Данное ПО позволяет: получить более рациональный вариант решения задач обработки данных о преподавателях; освободить председателя ЦК от рутинной работы за счет ее автоматизации; заменить бумажные носители данных на электронные.

# Скриншоты

### Главное окно приложения
Главное окно программы позволяет управлять элементами проекта пользователя. Здесь можно взаимодействовать с таблицами, добавлять новые элементы, изменять настройки программы и многое другое.

![](http://aurathemes.ru/inely/p1.png)

### Дизайнер отчетов
Программа обладает очень богатым функционалом для создания любых видов отчетов, а также широким спектром операций над ними. Для этого имеется одноимённая встроенная утилита. С помощью неё можно создавать отчеты любой сложности.

![](http://aurathemes.ru/inely/p2.png)

Программа состоит из 8 взаимосвязанных модулей. Назначение модулей:
-	DBOperator – выборка информации из базы данных по запросу;
-	HeaderForm – главная форма;
-	ChildForm – отображение необходимой таблицы базы данных;
-	InfoForm – форма для отображения информации о преподавателе;
-	SearchForm – поиск преподавателей;
-	SplashScreen – загрузочное окно;
-	LoginForm – авторизация

## Требуется .NET Framework 4!

Приложение разработано в Visual Studio 2013 с использованием библиотек DevExpress 14.1.8. Для полного функционирования разархивируйте help.zip (веб-справка) и sqlite_app.zip (SQLite дизайнер) в `../bin/Release`.

## Standalone installer

Также имеется возможность создать индивидуальный альтернативный (автономный) установочный файл. Его исходники расположены в `../Extras/Inno Script/` и снабжены комментариями. Для удачной компиляции потребуется **Inno Setup 5.5.1 Unicode & Inno Setup Compiler 5.5.1**.

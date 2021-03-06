﻿using System;
using System.Collections.Generic;
using System.Linq;

using System.Data.SQLite;
using System.Data;

namespace Elementors_arm {
    public class DBOperator {
        private static DBOperator instance = new DBOperator();

        public static DBOperator Instance {
            get { return instance; }
        }
       
        public DataTable GetTableByName(string tableName) {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=data.db;Version=3;");
            //Инициализация соединения с указанной строкой подключения
            m_dbConnection.Open();
            //Открывает соединение

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM " + tableName, m_dbConnection);
            //Инициализация адаптера данных с запросом Select и с указанной связью

            DataTable dt = new DataTable(tableName);
            //Инициализация экземпляра класса с указанным именем таблицы
            adapter.Fill(dt);
            //Добавление строк для получения соответствия строкам в источнике данных
            return dt;
        }

        public DataTable Information() //Функция "Информация о..."
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=data.db;Version=3;");
            //Инициализация соединения с указанной строкой подключения
            m_dbConnection.Open();
            //Открывает соединение

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select Дисциплины.НаименованиеДисциплины, Образование.Образование, " +
            "Образование.Аттестация, Образование.КвалификационнаяКатегория, Sum(Рейтинг.КоличествоБаллов) " +
            "as КоличествоБаллов from ((Дисциплины inner join Преподаватели on Дисциплины.КодДисциплины " +
            "= Преподаватели.КодДисциплины) inner join Образование on Преподаватели.КодПреподавателя " +
            "= Образование.КодПреподавателя) inner join Рейтинг on Преподаватели.КодПреподавателя = " +
            "Рейтинг.КодПреподавателя group by Дисциплины.НаименованиеДисциплины, Образование.Образование, " +
            "Образование.Аттестация, Образование.КвалификационнаяКатегория, Преподаватели.КодПреподавателя " +
            "having ((Преподаватели.КодПреподавателя) = " + Data.ValueOfPrepod + ")", m_dbConnection);
            //Инициализация адаптера данных с запросом Select и с указанной связью

            DataTable dt = new DataTable();
            //Инициализация экземпляра класса с указанным именем таблицы
            adapter.Fill(dt);
            //Добавление строк для получения соответствия строкам в источнике данных
            return dt;
        }

        public DataTable Search() //Функция "Поиск преподавателя"
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=data.db;Version=3;");
            m_dbConnection.Open();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter("select Преподаватели.ФИО as ФИО, Рейтинг.КоличествоБаллов as КоличествоБаллов, " +
            "Справочник_рейтинга.Наименование as Наименование from Преподаватели inner join " +
            "(Справочник_рейтинга inner join Рейтинг on " +
            "Справочник_рейтинга.КодРейтинга = Рейтинг.КодРейтинга) on " +
            "Преподаватели.КодПреподавателя = Рейтинг.КодПреподавателя where " +
            "((Преподаватели.ФИО)='" + Data.ValueOfSearch + "')", m_dbConnection);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
            
    }
}

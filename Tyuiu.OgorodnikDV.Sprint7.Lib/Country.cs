namespace Tyuiu.OgorodnikDV.Sprint7.Lib
{
    
    /// Модель данных для страны.
    
    public class Country
    {
        public string Name { get; set; } // Название страны
        public string Capital { get; set; } // Столица
        public double Area { get; set; } // Площадь
        public long Population { get; set; } // Население
        public string PredominantNationality { get; set; } // Преобладающая национальность
        public bool IsDeveloped { get; set; } // Развита ли страна
    }
    //`public` — модификатор доступа, позволяющий обращаться к этому свойству из любого другого кода.  
    //`{ get; set; }` — это авто-свойство с методами доступа:  
    //`get` — позволяет получить (прочитать) значение свойства.  
    //`set` — позволяет установить (записать) новое значение в свойство.  
}
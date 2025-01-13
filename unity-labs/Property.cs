
namespace Property
{
    public class Car
    {
        // 멤버변수
        private string color;

        // 생성자
        public Car()
        {
            this.color = "Black";
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return this.color;
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                color = value;
            }
        }

        public string Make
        {
            get
            {
                return "한국자동차";
            }
        }

        private string _Type;

        public string Type
        {
            set
            {
                _Type = value;
            }
        }
        
        public string Name { get; set; }
    }
    
    class Test
    {
        static void Print()
        {
            Car car1 = new Car();
            car1.SetColor("Red");
            Console.WriteLine(car1.GetColor()); // Red
            
            Car whiteCar = new Car();
            whiteCar.SetColor("White");
            Console.WriteLine(whiteCar.GetColor());

            Car k = new Car();
            // k.Make = ""; // 프로퍼티 'Property.Car.Make'은(는) setter가 없습니다
            Console.WriteLine(k.Make);

            Car car = new Car();
            car.Type = "중형";
            // Console.WriteLine(car.Type); // 프로퍼티 'Property.Car.Type'은(는) getter가 없습니다
            
            Car myCar = new Car();
            myCar.Name = "좋은차";
            Console.WriteLine(myCar.Name);
        }
    }
}


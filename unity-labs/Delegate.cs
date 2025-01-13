namespace _2;

/*
 * 대리자(Delegate)란?
   
   매개 변수 목록 및 반환 형식이 있는 메서드에 대한 참조(포인터)를 나타내는 형식
   -> 메서드 대신 호출
   
   메서드의 매개 변수에 메서드 자체(대리자)를 전달 가능
   -> 내장된 닷넷 API에 많이 사용
   
   영어 단어 delegate는 '위임하다' 또는 '대신하다'의 의미가 있습니다
   함수 자체를 데이터 하나로 보고 의미 그대로 다른 메서드를 대신 실행하는 기능
 */

public class Delegate
{
    static void GoForward() => Console.WriteLine("직진");
    static void GoLeft() => Console.WriteLine("좌회전");
    static void GoFast() => Console.WriteLine("과속");
    // static void GoRight() => Console.WriteLine("우회전");
    delegate void CarDriver();

    static void RunLambda(Action action) => action();

    static void Test()
    {
        //GoForward();  //[1] 내가 직접 운동
        //CarDriver goHome = new CarDriver(GoForward);  //[2] 대리 운전
        CarDriver goHome = GoForward;
        goHome += GoLeft;
        goHome += GoFast;
        goHome -= GoFast;
        goHome += delegate () { Console.WriteLine("우회전"); };  //[3] 무명 메서드/익명 함수
        // goHome += delegate { Console.WriteLine("후진"); };
        goHome += () => Console.WriteLine("후진");  //[4] 람다 식
        goHome();  // goHome.Invoke();

        // 내장된 대리자 형식을 통해서 직접 대리자 개체 생성: Func<T>, Action<T>, Predicate<T>, ...
        Action driver = GoForward;
        driver += GoLeft;
        driver += delegate () { Console.WriteLine("우회전"); };
        driver += () => Console.WriteLine("후진");
        driver();  // 트리거(방아쇠)

        Action go = () => Console.WriteLine("운전");
        go();

        RunLambda(() => Console.WriteLine("매개 변수로 람다 식(함수 이름, 무명 메서드) 전달"));
    }
}
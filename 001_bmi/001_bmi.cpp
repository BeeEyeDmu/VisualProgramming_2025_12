// 001_bmi.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <stdio.h>

int main()
{
    // 사용자가 입력하는 체중과 키를 받는다
    // bmi를 계산한다
    // bmi를 출력한다
    double w;   // 체중
    double h;   // 키

    printf("키를 입력하세요(cm) : ");
    scanf_s("%lf", &h);

    printf("체중을 입력하세요(kg) : ");
    scanf_s("%lf", &w);

    h /= 100;
    double bmi = w / (h * h);

    printf("bmi = %lf\n", bmi);
}
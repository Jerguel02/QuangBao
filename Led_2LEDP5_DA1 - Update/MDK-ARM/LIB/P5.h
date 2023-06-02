#ifndef __P5_H__
#define __P5_H__

#include "stm32f4xx_hal.h"
#include "stdlib.h"

#define SCAN_TYPE 16
#define MAX_BIT       8


#define LAT       12  //B
#define OE        3  //B
#define clk       0   //B

#define D         1   //B
#define C         14  //B
#define B         10 	//B
#define A         13  //B

#define A_SSET 0x00000001<<A
#define B_SSET 0x00000001<<B
#define C_SSET 0x00000001<<C
#define D_SSET 0x00000001<<D
#define A_RSET 0x00000001<<(A+16)
#define B_RSET 0x00000001<<(B+16)
#define C_RSET 0x00000001<<(C+16)
#define D_RSET 0x00000001<<(D+16)

#define B2        7 //a6 
#define R2        5 //a4
#define G2        6 //a5

#define B1        4 //a3
#define R1        2 //a1
#define G1        3 //a2


#define OE_P       GPIOB
#define xuat_P     GPIOB
#define clk_P      GPIOB
#define Control_P  GPIOB
#define data_PORT  GPIOA

#define P5_W  63
#define P5_H  31


void ngatquetled(void);
void display(void);
void scan16S(char so);
void SET_dosang(uint16_t sang);
uint16_t GET_dosang(void);


	
#endif  //__P5_H__


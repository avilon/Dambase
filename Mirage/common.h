#ifndef COMMON_H_INCLUDED
#define COMMON_H_INCLUDED

#define EMPTY 0
#define WHITE 1
#define BLACK 2
#define MAN   4
#define KING  8
#define EDDGE 16
#define TAKEN 32

#define WHITE_MAN  ( WHITE | MAN )
#define WHITE_KING ( WHITE | KING )
#define BLACK_MAN  ( BLACK | MAN )
#define BLACK_KING ( BLACK | KING )

#define BOARD_SIZE    66
#define SQUARES_COUNT 50

#endif // COMMON_H_INCLUDED
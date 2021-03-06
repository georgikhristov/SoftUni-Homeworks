﻿function solve(input) {
    var numbers = input[0].split(/[ ()]+/).filter(Boolean);
    
    var isOdd = numbers[0] % 2 !== 0;
    var counter = 1;
    var counterMax = counter;

    for (var i = 0; i < numbers.length - 1; i++) {
        if (numbers[i]==0) {
            counter++;
            if (counter > counterMax) {
                counterMax = counter;
            }
            if(i > 0){
                numbers[i] = parseInt(numbers[i - 1] + 1);
            }
            continue;
        }

        var isOddCurrent = numbers[i] % 2 !== 0;
        var isOddNext = numbers[i + 1] % 2 !== 0;
        
        if (isOddCurrent != isOddNext) {
            counter++;
            if (counter > counterMax) {
                counterMax = counter;
            }
        } else {
            counter = 1;
        }
    }
    
    console.log(counterMax);
}

//solve(['(3) (22) (-18) (55) (44) (3) (21)']); console.log(4);
//solve(['(1)(2)(3)(4)(5)(6)(7)(8)(9)(10)']); console.log(10);
//solve(['  ( 2 )  ( 33 ) (1) (4)   (  -1  ) ']); console.log(3);
//solve(['(102)(103)(0)(105)  (107)(1)']); console.log(4);
//solve(['(2) (2) (2) (2) (2)']); console.log(1);
//solve(['(1) (0) (0) (0) (0) (0) (1)']); console.log(7);
//solve(['(1) (0) (0) (0) (0) (0) (0) (1)']); console.log(7);
//solve(['(0) (0) (0) (0) (0) (0)']); console.log(6);
//solve(['(1) (1) (0) (3) (0) (5) (0) (7) (1) (2) (3)']); console.log(7);
//solve(['(2) (3) (4) (0) (6) (7) (8) (0) (10) (0) (-12) (2) (3) (4) (5) (6)']);
//console.log(11);
//solve(['  (  1 )  ( 11 ) (    20 ) (15 ) (10)(0   ) (   2)(3) (4) (0) (6) (7) (8) (0) (10) (0) (-12)( 11 ) (    20 ) (15 ) (10)(0   ) (   2)(3) (4) (0) (6) (7) (8) (0) (10) (0) (-12)( 11 ) (    20 ) (15 ) (10)(0   ) (   2)(3) (4) (0) (6) (7) (8) (0) (10) (0) (-12)( 11 ) (    20 ) (15 ) (10)(0   ) (   2)(3) (4) (0) (6) (7) (8) (0) (10) (0) (-12) (4) (0) (6) (7) (8) (0) (10) (0) (-12) (4) (0) (6) (7) (8    ) (0) (10            ) (0) (-12) (4) (0) (6) (7) (8) (0) (10) (0) (-12) (4) (0) (6) (7) (8) (0) (10) (0) (-12) (4) (0) (6) (7) (8) (0) (10) (0) (-12) (4) (0) (6) (7) (8) (0    ) (        10) (0) (-12) (4) (0) (6) (7) (8) (0) (10)    (    0    )      (       -12       ) (4)(0)(6)(7) (8) (0        ) (10) (0) (-12)']);
//console.log(64);
//solve(['(2) (2) (2)(2) (2) (2)(2) (2) (2)(2) (2) (2)(2) (2) (2)(2) (2) (2)(2) (2) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0)(2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0)(2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0)(2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0)(2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (2) (  33) (44) (55  ) (0  ) (  77) (88) ( 0 )   (0) (  11  )(22)(0)(0)(0)(2  ) (0) (4) (1) (2) (0) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1) (1)']);
//console.log(500);


function original(input) {
    var nums = input[0].split(/[ ()]+/).filter(Boolean).map(Number);
    var bestLen = 0;
    var len = 0;
    var shouldBeOdd = (nums[0] % 2 != 0);
    for (var num in nums) {
        var isOdd = num % 2 != 0;
        if (isOdd == shouldBeOdd || num == 0) {
            len++;
        } else {
			shouldBeOdd = isOdd;
            len = 1;
        }
        shouldBeOdd = !shouldBeOdd;
        if (len > bestLen) {
            bestLen = len;
        }
    }
    console.log(bestLen);
}

original(['5 0 0 0 ']);
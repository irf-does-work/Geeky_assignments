function IsLeapYear(year){
    if (year % 400 == 0 || (year % 4 == 0 && year % 100 !=0)) {
        console.log(year + " is a leap year");
    }

    else {
        console.log(year + " is NOT a leap year")
    }

}

IsLeapYear(2010);
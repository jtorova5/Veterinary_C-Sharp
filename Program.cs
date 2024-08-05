using PruebaC_sharp_JhonatanToro.Models;

var dog1 = new Dog(1,"grecia",new DateOnly(2021, 04, 15),"criolla","panela",17,true,"tímido","100200","medio","pelo corto");
var dog2 = new Dog(2,"pepito",new DateOnly(2022, 05, 10),"bulldog","blanco",20,false,"normal","100300","alto","pelo corto");

VeterinaryClinic.SaveDog(dog1);
VeterinaryClinic.SaveDog(dog2);

var cat1 = new Cat(1,"hidraulico",new DateOnly(2020,12,24),"siames","vainilla",5,true,"pelo corto");
var cat2 = new Cat(2,"alaska",new DateOnly(2021,06,10),"persa","nieve",4,false,"pelo largo");

VeterinaryClinic.SaveCat(cat1);
VeterinaryClinic.SaveCat(cat2);


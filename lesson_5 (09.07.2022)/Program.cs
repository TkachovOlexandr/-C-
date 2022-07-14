//using Traffic_lights_namespace;

//TrafficLights trafficLights = new TrafficLights("ss");
//trafficLights.Run();

using MyArrayNamespace;

//MyArray myArray = new MyArray();
//for (int i = 0; i < 5; i++)
//    myArray[i] = 2 * i + 1;
//myArray.Show();
//myArray.Delete(3);
//myArray.Show();

int[] arr = new int[] { 1, 58, 78, 3, 69, 12 };
MyArray myArray_1 = new MyArray();
myArray_1.MyArr = arr;
myArray_1.Show(myArray_1.SortArrayUp(0, myArray_1.ArrayLength - 1));
myArray_1.Delete(2);
myArray_1.Show(myArray_1.SortArrayUp(0, myArray_1.ArrayLength - 1));
//myArray_1.SortArray(0, myArray_1.ArrayLength - 1);
//myArray_1.Show();
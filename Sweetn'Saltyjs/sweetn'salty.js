<!DOCTYPE html>
<html>
<head>
   <title> JavaScript Operators</title>
   <script>
    {  var sweet = 0;
       var salty = 0;
       var sweetnSalty = 0;
       const nArray = new Array(1002);

       for( var n = 1; n < ts1001; n++){

           nArray(n) = n.toString();
           if (n % 3 = = 0){
               nArray(n) = "Sweet";
           }
           else if(n % 5 = = 0)
           { 
             nArray(n)  = "Salty";
             salty += 1;
           }
           if (n % 3 = = 0 && n % 5 = = 0){

              nArray(n) = "Sweet'nSalty";
              sweetnSalty += 1;
           }
       
       for (var m = 0; m < nArray.Length; m++)
       {
           document.write("{0} ", nArray(m));
           if ((m + 1) % 10 = = 0) document.write("");
       }
       document.write("\nThere are {0} Sweet", sweet);
       document.write ("There are {0} Salty, salty");
       document.write ("There are {0} Sweet'nSalty", sweetnSalty);

       
    }


</head>

</html>
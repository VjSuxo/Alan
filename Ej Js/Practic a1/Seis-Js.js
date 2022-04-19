function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var a = parseInt(document.getElementById("A").value);
    var b = parseInt(document.getElementById("B").value);
    a = a*a;
    b = b*b;
    var area = Math.sqrt(a+b);
 
    areaResultado.innerHTML = "" + area;
   }
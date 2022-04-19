function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var a = parseInt(document.getElementById("A").value);
    var b = parseInt(document.getElementById("B").value);
    
    var area = a*b;
 
    areaResultado.innerHTML = "" + area;
   }
function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var b = parseInt(document.getElementById("base").value);
    
    var area = 150*b;
 
    areaResultado.innerHTML = "" + area;
   }
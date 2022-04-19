function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var b = parseInt(document.getElementById("base").value);
 
    if(b > 18){
        areaResultado.innerHTML = "Si Puede votar ";
    }
    else{
        areaResultado.innerHTML = "No Puede votar ";
    }
 
   }
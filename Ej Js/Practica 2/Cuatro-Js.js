function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var b = parseInt(document.getElementById("base").value);
 
    if(b <= 2){
        b = b * 5;
        areaResultado.innerHTML = "El costo es de "+b;
        
    }
    else if(b==3 ){
        b = b * 4;
        areaResultado.innerHTML = "El costo es de "+b;
    }
    else if(b<=5)
    {
        b = b * 3;
        areaResultado.innerHTML = "El costo es de "+b;
    }
    else if(b>10){
        b = b * 2;
        areaResultado.innerHTML = "El costo es de "+b;
    }
    
   }
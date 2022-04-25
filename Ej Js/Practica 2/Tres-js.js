function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var b = parseInt(document.getElementById("base").value);
 
    if(b <= 10){
        areaResultado.innerHTML = "Puede comprar tarjeta";
    }
    if(b>=11 && b <=100){
        areaResultado.innerHTML = "Puede comprar chocolates";
    }
    if(b>=101 && b<=200)
    {
        areaResultado.innerHTML = "Puede comprar Flores";
    }
    if(b>200){
        areaResultado.innerHTML = "Puede comprar un anillo";
    }
    
   }
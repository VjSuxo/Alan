function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    var a = document.getElementById("A").value;
    if(a >= 100 && a>=200 ){ 
        areaResultado.innerHTML = a*0.12;
    }
    else{
        if(a <100 ){
            areaResultado.innerHTML = a*0.10;
        }
        else if(a >= 200){
            areaResultado.innerHTML = a*0.15;
        }
    }
   }
function obtenerArea(){
    var areaResultado = document.getElementById("areaResultado");
    
    var x = 1500;
    var cont = "";
    for(var i = 1; i <= 6 ; i++){
        x+=1500*0.10;
        cont+="Año :"+i+" Salario :"+x+" || ";
    }
    areaResultado.innerHTML=cont;    
   }
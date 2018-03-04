$(document).ready(function(){
    $("#colorButton").on('click', function(){
        $("#p1").css({'background-color': 'rgb('+ GetColors() + ',' + GetColors() + ',' + GetColors()+ ')'})
        $("#p1").css({'color': 'rgb('+ GetColors() + ',' + GetColors() + ',' + GetColors()+ ')'})
        $("#p2").css({'background-color': 'rgb('+ GetColors() + ',' + GetColors() + ',' + GetColors()+ ')'})
        $("#p2").css({'color': 'rgb('+ GetColors() + ',' + GetColors() + ',' + GetColors()+ ')'})
        $("#p3").css({'background-color': 'rgb('+ GetColors() + ',' + GetColors() + ',' + GetColors()+ ')'})
        $("#p3").css({'color': 'rgb('+ GetColors() + ',' + GetColors() + ',' + GetColors()+ ')'})
        
    })

})

function GetColors(){
    var validColor = false;
   
	return (Math.ceil(Math.random() * 255));	
   }


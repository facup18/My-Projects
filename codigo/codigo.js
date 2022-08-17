
function convertStringTres(){
    let array = [];
    let text = document.getElementById("convertStringText").value;
    let size = text.length;
    for(let i = 0; i < size;i++){
        let numAscii = text.charCodeAt(i);
        let convert = numAscii + 3;
        let letter = String.fromCodePoint(convert);
        array.push(letter);
    }
    document.getElementById("showText").value = array.join("");
}

function deconvertStringTres(){
    let array = [];
    let text = document.getElementById("deconvertStringText").value;
    let size = text.length;
    for(let i = 0; i < size;i++){
        let numAcii = text.charCodeAt(i);
        let convert = numAcii - 3;
        let letter = String.fromCodePoint(convert);
        array.push(letter);
    }
    document.getElementById("showTextDeconvert").value = array.join("");
}


function convertStringKey(){
    let key = document.getElementById("convertKey").value;
    let arrKey = [];
    for(let i = 0; i < key.length;i++){
        
        let num = key[i];
        
        arrKey.push(num);
    }

    let array = [];
    let text = document.getElementById("convertTextKey").value;
    let cout = 0; 

    for(let i = 0; i < text.length;i++){
        if(cout === arrKey.length){
            cout = 0;
        }

        let numAscii2 = text.charCodeAt(i);
        let convert = numAscii2 + Number(arrKey[cout]);
        
        let letter = String.fromCodePoint(convert);
        array.push(letter);
        cout++;
    }
    document.getElementById("showTextConvertKey").value = array.join("");
}

function deconvertStringKey(){
    let key = document.getElementById("deconvertKey").value;
    let arrKey = [];
    for(let i = 0; i < key.length;i++){
        
        let num = key[i];
        
        arrKey.push(num);
    }

    let array = [];
    let text = document.getElementById("deconvertTextKey").value;
    let cout = 0; 

    for(let i = 0; i < text.length;i++){
        if(cout === arrKey.length){
            cout = 0;
        }

        let numAscii2 = text.charCodeAt(i);
        let convert = numAscii2 - Number(arrKey[cout]);
        
        let letter = String.fromCodePoint(convert);
        array.push(letter);
        cout++;
    }
    document.getElementById("showTextDeconvertKey2").value = array.join("");
}

function choose1(){
    if(document.getElementById("radio1").checked){
        document.getElementById("form1").style.visibility = "visible";
        document.getElementById("form2").style.visibility = "hidden";
        document.querySelector('#radio1').checked = true;
    }else if(document.getElementById("radio2").checked){
        document.getElementById("form2").style.visibility = "visible";
        document.getElementById("form1").style.visibility = "hidden";
        document.querySelector('#radio4').checked = true;
    }

}

function choose2(){
   if(document.getElementById("radio3").checked){
        document.getElementById("form2").style.visibility = "hidden";
        document.getElementById("form1").style.visibility = "visible";
        document.querySelector('#radio1').checked = true;
    }else if(document.getElementById("radio4").checked){
        document.getElementById("form2").style.visibility = "visible";
        document.getElementById("form1").style.visibility = "hidden";
        document.querySelector('#radio4').checked = true;
    }

}
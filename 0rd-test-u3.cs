    .reg-tab{background-color: #111;
    border: solid 5px #141414;
    display: block;
    width:465px;
    height: 650px;position: relative;
    margin: 0 auto;text-align: center;}
    
    .reg-tabbor{
    position: absolute;
    top: 0;
    left: 0;
    display: block;
    width: 100%;
    height: 50px;}
    
    .reg-tab input{display: none;}
    
    .reg-tab label {cursor: pointer;
    font-family: 'Zen Kaku Gothic Antique';
    line-height: 1;
    border-bottom: solid 2px var(--clr4);
    margin: 5px;
    display: inline-block;
    color: #fff;
    font-size: 12px;
    padding:8px;position: absolute;
    top: 0;
    letter-spacing: 1px;
    transition: all 0.5s ease;}
    
    label[for=reg-tab1]{left: 0;}
    label[for=reg-tab2]{left: 110px;}
    label[for=reg-tab3]{left:190px;}
    label[for=reg-tab4]{left:267px;}
    label[for=reg-tab5]{left:360px;}
    
    input:checked + label{
    border-bottom: solid 2px #fff!important;
    color: var(--clr2);
    border: transparent;
}

    
    .reg-tab .rcxx{position: absolute;
    top: 50px;
    transition: ease 1s;
    display: none;
    height:570px;
    width:415px;overflow: auto;
    pointer-events: none;
    border: solid 1px var(--clr1);
    left:20px;}
    
    .reg-tab .rcxx1,.reg-tab .rcxx2,.reg-tab .rcxx3,.reg-tab .rcxx4,.reg-tab .rcxx5{background: rgba(0, 0, 0, 0.25);padding: 10px}

    .reg-tabbor input#reg-tab1:checked ~ .rcxx1,input#reg-tab2:checked ~ .rcxx2,input#reg-tab3:checked ~ .rcxx3,input#reg-tab4:checked ~ .rcxx4,input#reg-tab5:checked ~ .rcxx5{pointer-events: all; display: block;}


    .minirgg1{border: 1px inset transparent;
    border-image: radial-gradient(#00000000 80%,var(--clr2));
    -moz-border-image: -moz-radial-gradient(#00000000 80% ,var(--clr2));
    -webkit-border-image: -webkit-radial-gradient(#00000000 80% ,var(--clr2));
    border-image-slice: 1;
    display: block;position: relative;
    padding: 10px;}
    
    .bb0x{display: block;
    position: absolute;
    border: solid 1px black;
    width: 100%;
    text-align: center;
    line-height: 1;
    top: -5px;}
    
    .minirgg2{border: 1px inset transparent;
    border-image: radial-gradient(#00000000 80%,var(--clr2));
    -moz-border-image: -moz-radial-gradient(#00000000 80% ,var(--clr2));
    -webkit-border-image: -webkit-radial-gradient(#00000000 80% ,var(--clr2));
    border-image-slice: 1;
    display: inline-block;height: 245px;overflow:auto;
     width:245px;margin: 5px}
    
    .bb0x1{display: inline-block;
    position: absolute;
    border: solid 1px black;
    width:245px;
    text-align: center;
    line-height: 1;
    top: -5px;}   

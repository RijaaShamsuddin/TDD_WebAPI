import React from 'react'
import { Button } from '../helpers/Buttons';

const buttons = [
  new Button("%","%","btn-percent btn-all","button"),
  new Button("CE","CE","btn-ce btn-all","button"),
  new Button("C","C","btn-c btn-all","button"),
  new Button("<X","<X","btn-back btn-all","button"),
  new Button("7",7,"btn-7 btn-all","button"),
  new Button("8",8,"btn-8 btn-all","button"),
  new Button("9",9,"btn-9 btn-all","button"),
  new Button("/","divide","btn-divide btn-all","button"),
  new Button("4",4,"btn-4 btn-all","button"),
  new Button("5",5,"btn-5 btn-all","button"),
  new Button("6",6,"btn-6 btn-all","button"),
  new Button("*","multiply","btn-multiply btn-all","button"),
  new Button("1",1,"btn-1 btn-all","button"),
  new Button("2",2,"btn-2 btn-all","button"),
  new Button("3",3,"btn-3 btn-all","button"),
  new Button("-","subtract","btn-subtract btn-all","button"),  
  new Button("0",0,"btn-0 btn-all","button"),
  new Button("=","equals","btn-equal btn-all","button"),
  new Button("+","add","btn-add btn-all","button"),
];


function Calculator() {

  const listOfButtons = buttons.map(button =>
    
    <button
      type={button.type}
      className={button.className}
      data-value={button.value}
    >
      {button.buttonText}
    </button>    
    );


  return (
    <div className="calculator-body">
      <div class="display-area">
        <input type="text" id="txt-calc-display" />      
      </div>
      
      <div className="calculator-buttons">
        {listOfButtons}
      </div>
    </div>
  )
}

export default Calculator;

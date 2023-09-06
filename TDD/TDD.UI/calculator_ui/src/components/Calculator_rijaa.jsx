import React from 'react'

function Calculator_rijaa() {
  let buttons_html = [];
  for (let index = 0; index < 10; index++) {
   buttons_html[index] = <button className="btn-child">{index}</button>;              
  }
   buttons_html[buttons_html.length+1] = <button className="btn-child">+</button>;
   buttons_html[buttons_html.length+1] = <button className="btn-child">-</button>;
   buttons_html[buttons_html.length+1] = <button className="btn-child">/</button>;
   buttons_html[buttons_html.length+1] = <button className="btn-child">*</button>;
   buttons_html[buttons_html.length+1] = <button className="btn-child">=</button>;
   buttons_html[buttons_html.length+1] = <button className="btn-child">CE</button>;
   buttons_html[buttons_html.length+1] = <button className="btn-child">C</button>;
    return (
    <div>
      <div className="calculator-body-r">
        <div className="display-area-r">
            <textarea className="textarea-r">
                0
            </textarea>
        </div>
        <div className="calculator-buttons-r">
           {buttons_html}
        </div>
        
      </div>
    </div>
  )
}

export default Calculator_rijaa;

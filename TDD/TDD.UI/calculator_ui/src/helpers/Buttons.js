export class Button{
    constructor(buttonText, value, className, type){
        this.buttonText = buttonText || '';
        this.value = value || '';
        this.className = className || '';
        this.type = type || 'text';
    }
}
  
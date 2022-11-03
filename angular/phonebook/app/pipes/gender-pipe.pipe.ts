import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'genderPipe'
})
export class GenderPipePipe implements PipeTransform {

  transform(value: unknown, ...args: unknown[]): unknown {
    if(args[0]=="Male"){
      return "Mr." + value;
  }
  else if(args[0]=="Monkey"){ 
      return "Dr. " + value;
  }
  else{
    return "Ms. " + value;
  }
  }

}

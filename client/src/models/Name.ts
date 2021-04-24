export class Name {
    first: string | null = null;
    middle: string | null = null;
    last: string | null = null;
  
    constructor(init?: Partial<Name>) {
      Object.assign(this, init);
    }
  }
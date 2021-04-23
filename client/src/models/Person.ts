import { Name } from "./Name";

export class Person {
  name: Name | null = null;
  cellPhoneNumber: string | null = null;
  emailAddress: string | null = null;
  iD: string | null = null;

  constructor(init?: Partial<Person>) {
    Object.assign(this, init);
  }
}
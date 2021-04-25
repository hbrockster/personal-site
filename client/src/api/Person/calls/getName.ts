import axios from "axios";
import { Name } from "@/models";

export async function getName(): Promise<Name> {
  const result = await axios({
    method: 'GET',
    url: 'api/person/name'
});
return new Name(result.data);
}

import { ServiceType } from "./serviceType";
import { User } from "./user";

export interface Appointment {
  date: Date;
  serviceTypeId: ServiceType["id"];
  userPhone: User["Phone"];
}

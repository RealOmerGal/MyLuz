import React, { useEffect } from "react";
import { ServiceType } from "../../../models/serviceType";
import ServiceTypeItem from "./service-type-item/ServiceTypeItem";

interface Props {
  services: ServiceType[];
}

function ServiceTypeList({ services }: Props) {
  return (
    <ul>
      {services.map((service) => (
        <ServiceTypeItem key={service.id} {...service} />
      ))}
    </ul>
  );
}

export default ServiceTypeList;

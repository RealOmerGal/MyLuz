import React, { useEffect, useState } from "react";
import { useMutation, useQuery } from "react-query";
import { serviceTypeController } from "../../controllers/service-type";
import { ServiceType } from "../../models/serviceType";
import ServiceTypeList from "../components/service-type/ServiceTypeList";

const services: Array<ServiceType> = [
  {
    id: "1",
    price: 20,
    timeFrame: 30,
    title: "AAsv",
  },
  {
    id: "2",
    price: 20,
    timeFrame: 30,
    title: "SAF",
  },
  {
    id: "1a",
    price: 20,
    timeFrame: 30,
    title: "Poas",
  },
  {
    id: "2b",
    price: 20,
    timeFrame: 30,
    title: "Seco",
  },
];

function ServiceTypes() {
  const { queries } = serviceTypeController;
  const services2 = useQuery<ServiceType>(queries.getServiceType);
  return <ServiceTypeList services={services} />;
}

export default ServiceTypes;

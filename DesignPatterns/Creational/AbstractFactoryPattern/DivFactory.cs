﻿namespace AbstractFactoryPattern
{
    public class DivFactory:IFactory
    {
        public Operation CreateOperation()
        {
            return new OperationDiv();
        }
    }
}
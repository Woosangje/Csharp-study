﻿using System;
using System.Reflection;
using System.Reflection.Emit;

namespace c16_1_3Reflection
{//https://morm.tistory.com/227 코드오류떠서 수정
   /* public class Program
    {
        public static void Main(string[] args)
        {
            AssemblyBuilder newAssembly = AssemblyBuilder.DefineDynamicAssembly(
                new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);

            ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");
            TypeBuilder newType = newModule.DefineType("Sum1To100");

            MethodBuilder newMethod = newType.DefineMethod("Calculate", MethodAttributes.Public, typeof(int), new Type[0]);

            ILGenerator generator = newMethod.GetILGenerator();

            generator.Emit(OpCodes.Ldc_I4, 1);

            for(int i =2; i <= 100; i++)
            {
                generator.Emit(OpCodes.Ldc_I4, i);
                generator.Emit(OpCodes.Add);
            }

            generator.Emit(OpCodes.Ret);
            newType.CreateType();

            object sum1To100 = Activator.CreateInstance(newType);

            MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculate");
            Console.WriteLine(Calculate.Invoke(sum1To100, null));
        }
    }*/
}
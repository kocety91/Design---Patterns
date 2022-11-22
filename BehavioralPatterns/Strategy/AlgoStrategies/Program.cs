using AlgoStrategies;
using AlgoStrategies.Models;

AbstractStrategy bogoSortAlgo = new BogoSort();
AbstractStrategy quickSortAlgo = new QuickSort();
AbstractStrategy mergeSortAlgo = new MergeSort();


var bogoClient = new Client(bogoSortAlgo);
var quickClient = new Client(quickSortAlgo);
var merchClient = new Client(mergeSortAlgo);

bogoClient.ContextInterface();
quickClient.ContextInterface();
merchClient.ContextInterface();

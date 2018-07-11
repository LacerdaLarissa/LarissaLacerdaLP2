#include <stdio.h>

#include <vector>

#define TAM 100010

using namespace std;

vector<int> museu[TAM];
int main()
{
	int mae, filha;
	int cont = 0;

	for(int i=0; i<TAM; i++)
	{
		scanf("%d %d", &mae, &filha);
		museu[mae].push_back(filha);

		if(museu[i].empty)
		{
			cont++;
		}

	}
	printf("%d", cont);

	return 0;
}

<?php

use Illuminate\Database\Seeder;

class BiodataSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run()
    {
        factory(App\biodata::class , function(Faker\Generator $faker){
            return [
                
                'name' => $faker->name,
                'email' => $faker->email,
            ];
        })->create();
    }
}

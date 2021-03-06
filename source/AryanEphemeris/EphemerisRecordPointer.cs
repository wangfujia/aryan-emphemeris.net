/***************************************************************************************************
 * Aryan Ephemeris
 * Copyright © 2018, Souvik Dey Chowdhury
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except
 * in compliance with the License. You may obtain a copy of the License at
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the License
 * is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and limitations under
 * the License.
 **************************************************************************************************/

namespace AryanEphemeris
{
    public struct EphemerisRecordPointer
    {
        public EphemerisRecordPointer(int offset, int coefficientSetCount, int coefficientCountPerSet)
        {
            Offset = offset;
            CoefficientSetCount = coefficientSetCount;
            CoefficientCountPerSet = coefficientCountPerSet;
        }

        public int Offset { get; }

        public int CoefficientSetCount { get; }

        public int CoefficientCountPerSet { get; }
    }
}